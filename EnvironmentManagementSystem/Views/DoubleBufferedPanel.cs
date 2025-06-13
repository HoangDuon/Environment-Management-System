using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Siticone.Desktop.UI.WinForms;

namespace DuAnCNPM.Views
{
    public class DoubleBufferedPanel : SiticonePanel
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern int ShowScrollBar(IntPtr hWnd, int wBar, int bShow);
        public DoubleBufferedPanel()
        {
            ShowScrollBar(this.Handle, 3, 0);
            this.Resize += (s, e) => ShowScrollBar(this.Handle, 3, 0);
            this.DoubleBuffered = true;
        }
    }
}
