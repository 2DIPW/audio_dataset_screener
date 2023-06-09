<div class="title" align=center>
    <h1>Audio Dataset Screener</h1>
	<div>音频数据集手工筛选辅助工具</div>
    <br/>
    <p>
        <img src="https://img.shields.io/github/license/2DIPW/audio_dataset_vpr">
    	<img src="https://img.shields.io/badge/.net-4.8-blue">
        <img src="https://img.shields.io/github/stars/2DIPW/audio_dataset_screener?style=social">
        
</div>

## 🚩 简介
一个适用于音频数据集手工筛选的辅助工具，支持以全键盘操作的方式便捷地完成数据集音频片段的试听、分类和筛选，可用于辅助 VITS/SoVITS/Diff-SVC/RVC/DDSP-SVC 等语音模型数据集的制作。

支持导入 [2DIPW/audio_dataset_vpr](https://github.com/2DIPW/audio_dataset_vpr) 的声纹识别结果，进行进一步的手工筛选。

## 💻 程序截图
![Screenshot](https://github.com/2DIPW/audio_dataset_screener/raw/master/img/screenshot_main.png)

## 🗝 使用方法
1. **向文件列表添加文件 或 打开工程文件**
    * 单击`添加项目`，在弹出的菜单中选择`文件...`或`目录...`，选择待筛选的音频数据集文件，即可将文件添加至文件列表。
    * 单击`工程文件`，在弹出的菜单中选择`打开工程...`，选择此前保存的工程文件，即可恢复之前的会话状态。或选择 [Audio Dataset VPR Classifier](https://github.com/2DIPW/audio_dataset_vpr) 生成的声纹识别结果文件，即可在声纹识别结果的基础上进行进一步的手工筛选。
    * 文件列表支持多选和点击表头排序。若加载了声纹识别结果，即可对声纹识别相似度进行排序，优先筛选可信程度低的识别结果。
    * `移除所选`会将选中项从列表中移除（不删除本地文件），`删除所选`会将选中项的本地文件**直接删除**。
    * `清空列表`会将所有项从列表中移除（不删除本地文件）。
2. **设置分类目录（用于分类功能，不需分类可跳过）**
    * 当数据集混杂有多个说话人的数据，需要将其分类到不同目录；或者不希望直接删除不需要的数据，而是暂时将其移至其他目录时，可以设置分类目录，最多可设置5个。
3. **开始试听并标记动作**
    * 按`▷║`按钮或键盘上的<kbd>F</kbd>键均可开始/暂停播放，文件列表也支持双击播放。
    * 按`◁◁`/`▷▷`按钮或键盘上的<kbd>A</kbd>/<kbd>D</kbd>键可以快进/快退，步长取决于设置区所设置的`进退步长`。
    * 按`△`/`▽`按钮或键盘上的<kbd>W</kbd>/<kbd>S</kbd>键可以切换上一条/下一条音频文件。
    * 如果选中了`列表自动播放`，则一条播放完毕后会自动切换到下一条。如果音频比较短，可能会来不及反应，这时可以取消列表自动播放功能或者设置`切换下条前等待`时间，在自动切换下一条音频前留一段时间对当前音频做出判断。
    * 受限于WMP的功能限制，`播放速度`仅支持部分格式音频文件的倍速播放（如支持\*.wav、\*.mp3等，而不支持\*.flac）
    * 按`1`/`2`/`3`/`4`/`5`按钮或键盘上的<kbd>1</kbd>/<kbd>2</kbd>/<kbd>3</kbd>/<kbd>4</kbd>/<kbd>5</kbd>键，可将当前播放的文件标记为“**待移动至对应的分类目录**”，并自动切换至下一条，如果某个分类目录未设置，按下则不会有反应。
        * 比如设置分类目录1为“*D:\kokomi*”，分类目录2为“*D:\qiqi*”，当听到当前播放的音频为kokomi的语音时，按下“1”，当听到当前播放的音频为qiqi的语音时，按下“2”。
    * 按`删`按钮或键盘上的<kbd>Delete</kbd>键，可将当前播放的文件标记为“**待删除**”，并自动切换至下一条。
    * 按键盘上的<kbd>R</kbd>键可取消当前播放的文件的标记。<br><br>
    > ***请注意***：
    >  * 文件列表第一列的“▷”符号指示当前所播放的文件，所有的标记均会打给“▷”符号所指示的文件，而不一定是当前选中高亮的文件。
    >  * “动作”列中的标记仅为待执行的操作，此时还并未对文件产生实际影响，在执行动作之前仍有机会检查并反悔。
4. **（可选）保存当前会话状态至工程文件**
    * 单击`工程文件`，在弹出的菜单中选择`保存工程...`，即可将当前的会话状态（包括文件列表、已添加的分类筛选动作标记、分类目录设置）保存至工程文件，以便下次继续。<br><br>
    > ***请注意***：
    >  * 工程文件中记录音频文件的绝对路径，如果在下次载入该工程文件之前移动或删除了某些音频文件，则这些音频文件都将无法加载。
5. **检查并执行动作**
    * 完成试听工作后，文件列表中的“**动作**”列应该标记着每个文件的待执行操作，其中数字1\~5代表要将这个文件移至所设置的分类目录1\~5，“删”代表要将这个文件直接删除。
    * 如果要取消某些文件的动作标记，选中它们，并单击`取消所选`。如果要取消所有文件的动作标记，重新再来，则单击`全部取消`。
    * 如果要执行某些文件的动作标记，选中它们，并单击`执行所选`。
    * 如果确信无误，要直接应用所有文件的动作标记，单击`全部执行`。<br><br>
    > ***请注意***：
    >  * 一旦应用了动作，删除的文件即无法恢复，请慎重！
## 📥 运行环境
* Microsoft Windows 7 SP1及以上
* Microsoft .NET Framework 4.8
* 需安装有Windows Media Player
  * 若程序在启动时报错，请检查`控制面板`>`程序和功能`>`启用或关闭Windows功能`>`媒体功能`>`Windows Media Player`是否勾选

## ⚖ 开源协议

本项目基于 [GNU General Public License v3.0](https://github.com/2DIPW/audio_dataset_screener/blob/master/LICENSE.txt) 开源

*世界因开源更精彩*