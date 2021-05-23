using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MegaAnimator
{
    public partial class MainForm : Form
    {
        private Graphics g;

        private Timer timer = new Timer();

        private int ticks = 0;
        // private Timer timerScaleDown = new Timer();
        
        private const int Interval = 1;
        
        public MainForm() => InitializeComponent();
        
        private void FormMain_Load(object sender, EventArgs e)
        {
            AllocConsole();
            g = panelDrawCanvas.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            DoubleBuffered = true;
        }
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void buttonScale_Click(object sender, EventArgs e)
        {
           
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
          
        }

        private void buttonMoveByFunction_Click(object sender, EventArgs e)
        {
           
        }
    }
}