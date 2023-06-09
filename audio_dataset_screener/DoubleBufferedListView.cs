using System;
using System.Windows.Forms;

namespace audio_dataset_screener
{
    internal class DoubleBufferedListView : ListView
    {
        internal DoubleBufferedListView()
        {
            DoubleBuffered = true;
        }
    }
}
