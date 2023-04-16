using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace audio_dataset_screener
{
    internal class PlaybackProgress
    {
        private AxWMPLib.AxWindowsMediaPlayer WMP;
        public int Duration { get { return (int)(WMP.currentMedia.duration * 1000); } }
        public int CurrentPosition { get { return (int)(WMP.Ctlcontrols.currentPosition * 1000); } set { WMP.Ctlcontrols.currentPosition = value / 1000; } }
        public string DurationString { get { return WMP.currentMedia.durationString == string.Empty ? "00:00" : WMP.currentMedia.durationString; } }
        public string CurrentPostionString { get { return WMP.Ctlcontrols.currentPositionString == string.Empty ? "00:00" : WMP.Ctlcontrols.currentPositionString; } }
        public PlaybackProgress(AxWMPLib.AxWindowsMediaPlayer wmp) 
        {
            WMP = wmp;
        }
    }
}
