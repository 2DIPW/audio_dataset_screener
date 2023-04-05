using System;
using Shell32;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audio_dataset_screener
{
    internal class SoundInfo
    {
        private string fileName;
        private string filePath;
        private string duration;

        public string FileName { get { return fileName; } }
        public string FilePath { get { return filePath; } }
        public string Duration { get { return duration; } }

        public SoundInfo(string filePath) 
        {
            getSoundInfo(filePath);
        }

        private void getSoundInfo(string path)
        {
            try
            {
                ShellClass sh = new ShellClass();
                Folder dir = sh.NameSpace(Path.GetDirectoryName(path));
                FolderItem item = dir.ParseName(Path.GetFileName(path));

                fileName = dir.GetDetailsOf(item, 0);

                filePath = path;

                duration = dir.GetDetailsOf(item, 27);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
