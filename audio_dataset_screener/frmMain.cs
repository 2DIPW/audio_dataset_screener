using audio_dataset_screener.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace audio_dataset_screener
{
    public partial class frmMain : Form
    {
        private int current_playing; //记录当前播放项序号
        private int sortColumn = -1;//点击表头升序或降序排列
        private PlaybackProgress playbackProgress;
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            wmp.uiMode = "none";
            wmp.settings.volume = 100;
            wmp.enableContextMenu = false;
            wmp.settings.autoStart = false;
            comboPlaySpeed.SelectedIndex = 2;
            playbackProgress = new PlaybackProgress(wmp);//播放进度类
        }

        #region 共用方法
        private void set_current_playing(int index) //改变当前播放项
        {
            if (lvFileList.Items.Count == 0)
            {
                current_playing = 0; //若列表已空，则不进行播放标记的添加，并将当前播放项重置为0
                grpPlaycontrol.Enabled = false;
                grpAction.Enabled = false;
            }
            else
            {
                foreach (ListViewItem item in lvFileList.Items)//重置所有列表项的播放标记和选中情况
                {
                    item.SubItems[0].Text = "";
                    item.Selected = false;
                }
                lvFileList.Items[index].SubItems[0].Text = "▶"; //在当前播放项前加上标记符号
                lvFileList.Items[index].Selected = true;//选中当前播放项
                lvFileList.EnsureVisible(index);//滚动到当前播放项
                current_playing = index;
                grpPlaycontrol.Enabled = true;
                grpAction.Enabled = true;
                wmp.URL = lvFileList.Items[current_playing].SubItems[4].Text;//载入文件
            }
            labelFileCounter.Text = $"{(current_playing + 1).ToString()}/{lvFileList.Items.Count.ToString()}"; //更新播放项指示label
        }
        private delegate void set_progressbar_value(int value);

        private void wmp_stop()
        {
            timerSleep.Stop();//取消已进入延时等待的切换下一条操作
            wmp.Ctlcontrols.stop();
            timerPlay.Stop();//进度条停止走动
            tckbarPlayprogress.Value = 0;
        }
        private void apply_playspeed()
        {
            if (wmp.settings.isAvailable["Rate"])//受到wmp限制，部分格式不支持倍速播放
            {
                wmp.settings.rate = Double.Parse(comboPlaySpeed.Text);
            }
        }
        private void wmp_play()
        {
            timerSleep.Stop();//取消已进入延时等待的切换下一条操作
            if (comboPlaySpeed.SelectedIndex != 2)//wmp的播放速度不是全局设置，经常会被重置。当速度不是1x，只要开始播放就重新设置倍速。
            {
                apply_playspeed();
            }
            wmp.Ctlcontrols.play();
            timerPlay.Start();//进度条开始走动
;        }
        private void wmp_pause()
        {
            timerSleep.Stop();//取消已进入延时等待的切换下一条操作
            wmp.Ctlcontrols.pause();
            timerPlay.Stop();//进度条停止走动
        }

        private void wmp_next()
        {
            timerSleep.Stop();//取消已进入延时等待的切换下一条操作
            if (current_playing == lvFileList.Items.Count - 1)
            {
                set_current_playing(0);//列表循环
            }
            else
            {
                set_current_playing(current_playing + 1);
            }
            wmp_play();
        }

        private void wmp_previous()
        {
            timerSleep.Stop();//取消已进入延时等待的切换下一条操作
            if (current_playing == 0)
            {
                set_current_playing(lvFileList.Items.Count - 1);//列表循环
            }
            else
            {
                set_current_playing(current_playing - 1);
            }
            wmp_play();
        }
        private void set_move_action_for_current_playing(int folder_number)//为当前播放添加移动动作标记
        {
            System.Windows.Forms.TextBox[] folder_paths = { txtboxSortFolder1, txtboxSortFolder2, txtboxSortFolder3, txtboxSortFolder4, txtboxSortFolder5 };
            if (folder_paths[folder_number].Text != string.Empty)//如果对应分类目录未指定，则不响应用户输入
            {
                lvFileList.Items[current_playing].SubItems[1].Text = (folder_number + 1).ToString();
                wmp_next();
            }
        }
        private (int,int) apply_actions<T>(T items) where T : ICollection //应用动作标记
        {
            System.Windows.Forms.TextBox[] folder_paths = { txtboxSortFolder1, txtboxSortFolder2, txtboxSortFolder3, txtboxSortFolder4, txtboxSortFolder5 };

            lvFileList.BeginUpdate();

            int total_amount = items.Count;
            int succeed_amount = 0;

            processBar.Maximum = total_amount;
            processBar.Value = 0;
            processBar.Visible = true;
            

            foreach (ListViewItem item in items)
            {
                switch (item.SubItems[1].Text)
                {
                    case "":
                        succeed_amount++;
                        break;
                    case "删":
                        try
                        {
                            File.Delete(item.SubItems[4].Text);
                            item.Remove();
                            succeed_amount++;
                        }
                        catch { }
                        break;
                    default:
                        int folder_number = int.Parse(item.SubItems[1].Text) - 1; //动作标记中的目录编号-1即为目录数组序号
                        string new_path = Path.Combine(folder_paths[folder_number].Text, item.SubItems[2].Text);
                        try
                        {
                            File.Move(item.SubItems[4].Text, new_path);
                            item.SubItems[1].Text = string.Empty;//清除对应的动作标记
                            item.SubItems[4].Text = new_path;//更新文件路径
                            succeed_amount++;
                        }
                        catch { }
                        break;
                }
                processBar.PerformStep();
                
            }
            processBar.Visible = false;
            lvFileList.EndUpdate();
            return (total_amount, succeed_amount);
        }
        #endregion

        #region 文件列表处理逻辑
        private void btnAddFile_Click(object sender, EventArgs e) //添加文件
        {
            wmp_stop();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                lvFileList.BeginUpdate();

                string[] paths = openFileDialog.FileNames;

                List<string> existed_paths_in_filelist = new List<string>();
                foreach (ListViewItem item in lvFileList.Items) 
                {
                    existed_paths_in_filelist.Add(item.SubItems[4].Text);
                }//获取当前列表中的所有文件路径

                int total_amount = paths.Length;
                int succeed_amount = 0;

                processBar.Maximum = total_amount;
                processBar.Value = 0;
                processBar.Visible = true;
                

                foreach (string path in paths)
                {
                    try
                    {
                        SoundInfo soundinfo = new SoundInfo(path);
                        if (soundinfo.Duration != string.Empty & !existed_paths_in_filelist.Contains(soundinfo.FilePath))//如果无法读取时长，则认为不是受支持的音频文件，或如果列表中已存在相同路径的文件，都不予添加
                        {
                            ListViewItem lvItem = new ListViewItem();
                            lvItem.SubItems[0].Text = string.Empty;
                            lvItem.SubItems.Add(string.Empty);
                            lvItem.SubItems.Add(soundinfo.FileName);
                            lvItem.SubItems.Add(soundinfo.Duration);
                            lvItem.SubItems.Add(soundinfo.FilePath);
                            lvFileList.Items.Add(lvItem);
                            succeed_amount++;
                        }
                    }
                    catch { }
                    processBar.PerformStep();
                    
                }
                set_current_playing(0);//添加文件后重置当前播放项

                processBar.Visible = false;

                lvFileList.EndUpdate();

                if (total_amount - succeed_amount > 0)
                {
                    MessageBox.Show($"已成功添加{succeed_amount.ToString()}个文件，但失败{(total_amount - succeed_amount).ToString()}个\n可能是因为您选择了列表中已存在的文件或非音频文件", "存在错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
        }


        private void btnAddFolder_Click(object sender, EventArgs e) //添加目录
        {
            wmp_stop();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                lvFileList.BeginUpdate();

                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                FileInfo[] file = dir.GetFiles();

                List<string> existed_paths_in_filelist = new List<string>();

                foreach (ListViewItem item in lvFileList.Items) //获取当前列表中的所有文件路径
                {
                    existed_paths_in_filelist.Add(item.SubItems[4].Text);
                }

                int total_amount = file.Length;
                int succeed_amount = 0;

                processBar.Maximum = total_amount;
                processBar.Value = 0;
                processBar.Visible = true;
                


                foreach (FileInfo f in file)
                {
                    try
                    {
                        SoundInfo soundinfo = new SoundInfo(f.FullName);
                        if (soundinfo.Duration != string.Empty & !existed_paths_in_filelist.Contains(soundinfo.FilePath))
                        {
                            ListViewItem lvItem = new ListViewItem();
                            lvItem.SubItems[0].Text = string.Empty;
                            lvItem.SubItems.Add(string.Empty);
                            lvItem.SubItems.Add(soundinfo.FileName);
                            lvItem.SubItems.Add(soundinfo.Duration);
                            lvItem.SubItems.Add(soundinfo.FilePath);
                            lvFileList.Items.Add(lvItem);
                            succeed_amount++;
                        }
                    }
                    catch { }
                    processBar.PerformStep();
                    
                }

                set_current_playing(0);//添加文件后重置当前播放

                processBar.Visible = false;

                lvFileList.EndUpdate();

                if (total_amount - succeed_amount > 0)
                {
                    MessageBox.Show($"已成功添加{succeed_amount.ToString()}个文件，但失败{(total_amount - succeed_amount).ToString()}个\n可能是因为您选择了列表中已存在的文件或非音频文件", "存在错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnRemoveSelected_Click(object sender, EventArgs e) //移除选中项
        {
            if (lvFileList.SelectedItems.Count > 0)
            {
                lvFileList.BeginUpdate();
                wmp_stop();
                int last_selected_index = lvFileList.SelectedItems[lvFileList.SelectedItems.Count - 1].Index;

                processBar.Maximum = lvFileList.SelectedItems.Count;
                processBar.Value = 0;
                processBar.Visible = true;
                

                foreach (ListViewItem item in lvFileList.SelectedItems)
                {
                    item.Remove();
                    processBar.PerformStep();
                    
                }

                try
                {
                    set_current_playing(last_selected_index);//尝试将当前播放设为删除项之后的第一项
                }
                catch
                {
                    set_current_playing(lvFileList.Items.Count == 0 ? 0 : lvFileList.Items.Count - 1);//如果不成功，若文件列表已空，则重置，不为空则设为最后一项
                }

                processBar.Visible = false;

                lvFileList.EndUpdate();

            }
        }
        private void btnDeleteSelected_Click(object sender, EventArgs e) //删除选中项
        {
            if (lvFileList.SelectedItems.Count > 0)
            {
                if(MessageBox.Show("确实要删除所选的音频（包括本地文件）吗？该操作不可撤销！", "删除确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                lvFileList.BeginUpdate();
                wmp_stop();

                int total_amount = lvFileList.SelectedItems.Count;
                int succeed_amount = 0;
                int last_selected_index = lvFileList.SelectedItems[total_amount - 1].Index;

                processBar.Maximum = lvFileList.SelectedItems.Count;
                processBar.Value = 0;
                processBar.Visible = true;
                

                foreach (ListViewItem item in lvFileList.SelectedItems)
                {
                    try
                    {
                        File.Delete(item.SubItems[4].Text);
                        item.Remove();
                        succeed_amount++;
                    }
                    catch { }
                    processBar.PerformStep();
                    
                }

                processBar.Visible = false;

                lvFileList.EndUpdate();

                if (total_amount - succeed_amount > 0)
                {
                    MessageBox.Show($"已成功删除{succeed_amount.ToString()}个文件，但失败{(total_amount - succeed_amount).ToString()}个\n请检查您是否拥有文件的访问权限，或文件是否被占用", "存在错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                try
                {
                    set_current_playing(last_selected_index);
                }
                catch
                {
                    set_current_playing(lvFileList.Items.Count == 0 ? 0 : lvFileList.Items.Count - 1);
                }
            }
        }
        private void btnClearList_Click(object sender, EventArgs e) //清空列表
        {
            lvFileList.Items.Clear();
            wmp_stop();
            set_current_playing(0);
        }

        private void lvFileList_MouseDoubleClick(object sender, MouseEventArgs e) //文件列表双击播放
        {
            if (lvFileList.SelectedItems.Count > 0) //用户双击列表空白处时会取消选中，不响应此操作
            {
                set_current_playing(lvFileList.SelectedItems[0].Index);
                wmp_play();
            }
            
        }

        private void lvFileList_ColumnClick(object sender, ColumnClickEventArgs e)//点击表头排序功能
        {
            wmp_stop();
            if (e.Column != sortColumn)
            {
                sortColumn = e.Column;
                lvFileList.Sorting = SortOrder.Ascending;
            }
            else
            {
                if (lvFileList.Sorting == SortOrder.Ascending)
                    lvFileList.Sorting = SortOrder.Descending;
                else
                    lvFileList.Sorting = SortOrder.Ascending;
            }
            lvFileList.Sort();
            this.lvFileList.ListViewItemSorter = new ListViewItemComparer(e.Column,lvFileList.Sorting);
            set_current_playing(0);//排序后重置当前播放项
        }
        #endregion

        #region 播放控制逻辑
        private void btnPlayPause_Click(object sender, EventArgs e) //播放暂停键
        {
            if(wmp.playState.ToString()== "wmppsPlaying" | wmp.playState.ToString() == "wmppsScanForward")//有时wmp会自作聪明地把正在倍速播放的文件设为wmppsScanForward状态，麻了
            {
                    wmp_pause();
            }
            else
            {
                    wmp_play();
            }
        }


        private void btnNext_Click(object sender, EventArgs e) //下一条
        {
            wmp_next();
        }

        private void btnPrevious_Click(object sender, EventArgs e) //上一条
        {
            wmp_previous();
        }

        private void btnRew_Click(object sender, EventArgs e) //快退
        {
            if (wmp.playState.ToString() == "wmppsPlaying" | wmp.playState.ToString() == "wmppsScanForward")
            {
                int position = playbackProgress.CurrentPosition - (int)numericStep.Value * 1000;
                playbackProgress.CurrentPosition = position <= 0 ? 0 : position;//如果快退后播放位置<=0，则直接设为0
            }
        }
        private void btnFF_Click(object sender, EventArgs e) //快进
        {
            if (wmp.playState.ToString() == "wmppsPlaying" | wmp.playState.ToString() == "wmppsScanForward")
            {
                int position = playbackProgress.CurrentPosition + (int)numericStep.Value * 1000;
                if (position >= playbackProgress.Duration)
                {
                    if (chkListAuto.Checked)
                    {
                        wmp_next();
                    }
                    else
                    {
                        wmp_stop();
                    }
                }
                else
                {
                    playbackProgress.CurrentPosition = position;
                }
            }
        }

        private void tckbarVolume_ValueChanged(object sender, EventArgs e)//音量条
        {
            wmp.settings.volume = tckbarVolume.Value;
            tip.SetToolTip(tckbarVolume, $"音量：{tckbarVolume.Value}");
        }
        private void comboPlaySpeed_SelectedIndexChanged(object sender, EventArgs e)//倍速选择
        {
            apply_playspeed();
        }
        private void wmp_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e) //播放完毕事件
        {
            if (wmp.playState.ToString() == "wmppsMediaEnded")
            {
                if (chkListAuto.Checked)
                {
                    if (numericSleepTimeForAutoPlay.Value == 0)
                    {
                        BeginInvoke(new Action(() => { wmp_next(); }));
                    }
                    else
                    {
                        timerSleep.Interval = (int)numericSleepTimeForAutoPlay.Value * 1000;
                        timerSleep.Start();
                    }
                }
                else
                {
                    wmp_stop();
                }
            }
            
        }
        private void timerSleep_Tick(object sender, EventArgs e)
        {
            BeginInvoke(new Action(() => { wmp_next(); }));
        }
        private void timerPlay_Tick(object sender, EventArgs e) //实时播放进度条
        {
            try
            {
                tckbarPlayprogress.Maximum = playbackProgress.Duration;
                tckbarPlayprogress.Value = playbackProgress.CurrentPosition;
                labelPlayprogressString.Text = $"{playbackProgress.CurrentPostionString} / {playbackProgress.DurationString}";
            }
            catch { }
        }
        private void MoveTrackBarToMouseClickLocation(System.Windows.Forms.TrackBar trackbar, int a_mouseX)
        {
            double dblValue = ((double)a_mouseX / (double)trackbar.Width) * (trackbar.Maximum - trackbar.Minimum);
            trackbar.Value = (int)dblValue;
        }
        private void tckbarPlayprogress_MouseDown(object sender, MouseEventArgs e)
        {
            timerPlay.Stop();
        }
        private void tckbarPlayprogress_MouseUp(object sender, MouseEventArgs e)
        {
            MoveTrackBarToMouseClickLocation(tckbarPlayprogress, e.X);
            playbackProgress.CurrentPosition = tckbarPlayprogress.Value;
            timerPlay.Start();
        }


        #endregion

        #region 分类筛选逻辑
        private void btnSortFolder1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtboxSortFolder1.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSortFolder2_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtboxSortFolder2.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSortFolder3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtboxSortFolder3.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSortFolder4_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtboxSortFolder4.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnSortFolder5_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtboxSortFolder5.Text = folderBrowserDialog.SelectedPath;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lvFileList.Items[current_playing].SubItems[1].Text = "删";
            wmp_next();
        }

        private void btnToFolder1_Click(object sender, EventArgs e)
        {
            set_move_action_for_current_playing(0);
        }

        private void btnToFolder2_Click(object sender, EventArgs e)
        {
            set_move_action_for_current_playing(1);
        }

        private void btnToFolder3_Click(object sender, EventArgs e)
        {
            set_move_action_for_current_playing(2);
        }

        private void btnToFolder4_Click(object sender, EventArgs e)
        {
            set_move_action_for_current_playing(3);
        }

        private void btnToFolder5_Click(object sender, EventArgs e)
        {
            set_move_action_for_current_playing(4);
        }
        private void btnCancelSelectedActions_Click(object sender, EventArgs e)
        {
            if (lvFileList.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in lvFileList.SelectedItems)
                {
                    item.SubItems[1].Text = string.Empty;
                }
            }
        }

        private void btnCancelAllActions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要取消所有的筛选动作吗？该操作不可撤销！", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            foreach (ListViewItem item in lvFileList.Items)
            {
                item.SubItems[1].Text = string.Empty;
            }
        }

        private void btnApplySelectedActions_Click(object sender, EventArgs e)
        {
            if (lvFileList.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("确实要应用所选的筛选动作吗？该操作不可撤销！", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                {
                    return;
                }
                wmp_stop();
                grpPlaycontrol.Enabled = false;
                grpAction.Enabled = false;
                (int total_amount, int succeed_amount) = apply_actions(lvFileList.SelectedItems);
                if (total_amount - succeed_amount > 0)
                {
                    MessageBox.Show($"已成功处理{succeed_amount.ToString()}个文件，但失败{(total_amount - succeed_amount).ToString()}个\n请检查您是否拥有文件的访问权限，或文件是否被占用", "存在错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                set_current_playing(0);
            }
        }

        private void btnApplyAllActions_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确实要应用所有的筛选动作吗？该操作不可撤销！", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            wmp_stop();
            grpPlaycontrol.Enabled = false;
            grpAction.Enabled = false;
            (int total_amount, int succeed_amount) = apply_actions(lvFileList.Items);
            if (total_amount - succeed_amount > 0)
            {
                MessageBox.Show($"已成功处理{succeed_amount.ToString()}个文件，但失败{(total_amount - succeed_amount).ToString()}个\n请检查您是否拥有文件的访问权限，或文件是否被占用", "存在错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"已成功应用所有动作！", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            set_current_playing(0);
        }
        #endregion

        private void frmMain_KeyDown(object sender, KeyEventArgs e) //定义窗体热键
        {
            if (grpPlaycontrol.Enabled & grpAction.Enabled)
            {
                switch (e.KeyCode)
                {
                    case Keys.F:
                        btnPlayPause_Click(null, null);
                        break;
                    case Keys.A:
                        btnRew_Click(null, null);
                        break;
                    case Keys.D:
                        btnFF_Click(null, null);
                        break;
                    case Keys.W:
                        btnPrevious_Click(null, null);
                        break;
                    case Keys.S:
                        btnNext_Click(null, null);
                        break;
                    case Keys.Delete:
                        btnDelete_Click(null, null);
                        break;
                    case Keys.NumPad1:
                        btnToFolder1_Click(null, null);
                        break;
                    case Keys.NumPad2:
                        btnToFolder2_Click(null, null);
                        break;
                    case Keys.NumPad3:
                        btnToFolder3_Click(null, null);
                        break;
                    case Keys.NumPad4:
                        btnToFolder4_Click(null, null);
                        break;
                    case Keys.NumPad5:
                        btnToFolder5_Click(null, null);
                        break;
                    case Keys.D1:
                        btnToFolder1_Click(null, null);
                        break;
                    case Keys.D2:
                        btnToFolder2_Click(null, null);
                        break;
                    case Keys.D3:
                        btnToFolder3_Click(null, null);
                        break;
                    case Keys.D4:
                        btnToFolder4_Click(null, null);
                        break;
                    case Keys.D5:
                        btnToFolder5_Click(null, null);
                        break;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;//防止发出Windows默认提示音
            }
            
        }
        private void chkListAuto_CheckedChanged(object sender, EventArgs e)
        {
            if (chkListAuto.Checked)
            {
                numericSleepTimeForAutoPlay.Enabled = true;
            }
            else
            {
                numericSleepTimeForAutoPlay.Enabled = false;
            }
        }
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (ListViewItem item in lvFileList.Items)//判断是否还有未应用的动作
            {
                if(item.SubItems[1].Text != string.Empty)
                {
                    if (MessageBox.Show("还有未应用的筛选动作，确实要退出程序吗？", "筛选动作未应用", MessageBoxButtons.OKCancel) != DialogResult.OK)
                    {
                        e.Cancel = true;//取消关闭动作
                        return;
                    }
                    else
                    {
                        return;//直接结束FormClosing事件方法，关闭窗口
                    }
                }
                
            }
            
        }

        private void labelAbout_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/2DIPW/audio_dataset_screener");
        }
    }
}
