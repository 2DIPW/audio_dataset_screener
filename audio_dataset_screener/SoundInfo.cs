using System;
using Shell32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audio_dataset_screener
{
    internal class SoundInfo //读取音频文件时长
    {
        private string fileName;
        private string filePath;
        private string duration;

        public string FileName { get { return fileName; } }
        public string FilePath { get { return filePath; } }
        public string Duration { get { return duration; } }

        public SoundInfo(string filePath) 
        {
            if (File.Exists(filePath))
            {
                getSoundInfo(filePath);
            }
            else
            {
                duration = string.Empty;
            }
        }

        public Shell32.Folder GetShell32NameSpaceFolder(Object folder) 
        {
            Type shellAppType = Type.GetTypeFromProgID("Shell.Application");

            Object shell = Activator.CreateInstance(shellAppType);
            return (Shell32.Folder)shellAppType.InvokeMember("NameSpace",
          System.Reflection.BindingFlags.InvokeMethod, null, shell, new object[] { folder });
        }

        private void getSoundInfo(string path)
        {
            filePath = path;
            try
            {
                //Shell sh = new Shell();
                Folder dir = GetShell32NameSpaceFolder(Path.GetDirectoryName(path));
                FolderItem item = dir.ParseName(Path.GetFileName(path));

                fileName = dir.GetDetailsOf(item, 0);
                duration = dir.GetDetailsOf(item, 27);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                duration = string.Empty;
            }
        }
    }
}
