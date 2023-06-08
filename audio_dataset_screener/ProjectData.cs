using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audio_dataset_screener
{
    internal class ProjectData
    {
        public Dictionary<int,string> Labels { get; set; }
        public List<ProjectFileData> Files { get; set; }
    }

    internal class ProjectFileData
    {
        public string Filepath { get; set; }
        public int Label { get; set; }
        public float Similarity { get; set; }
    }
}
