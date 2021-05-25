using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using app.core;

namespace MegaAnimator
{
    public partial class MainForm : Form
    {
        private Graphics g;

        private Timer timer = new Timer();

        private int ticks = 0;
        // private Timer timerScaleDown = new Timer();

        private const int Interval = 1;

        private SpiralDrawer spiralDrawer = new SpiralDrawer(150, 50, 500, 50, 40);

        private SphereDrawer sphereDrawer = new SphereDrawer(150, 100, 750, 75);

        private SurfaceDrawer surfaceDrawer = new SurfaceDrawer(150, 100,
            -1.5, 1.5, 0.1,
            -1.5, 1.5, 0.1,
            100,
            60
        );
        
        private CubeDrawer cubeDrawer = new CubeDrawer(115, 60, 100);

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

        private void buttonDrawSpiral_Click(object sender, EventArgs e)
        {
            spiralDrawer.Draw(g);
        }

        private void buttonEraseSpiral_Click(object sender, EventArgs e)
        {
            spiralDrawer.Erase(g);
        }

        private void buttonDrawSphere_Click(object sender, EventArgs e)
        {
            sphereDrawer.Draw(g);
        }

        private void buttonEraseSphere_Click(object sender, EventArgs e)
        {
            sphereDrawer.Erase(g);
        }

        private void buttonDrawSurface_Click(object sender, EventArgs e)
        {
            surfaceDrawer.Draw(g);
        }
        
        private void buttonEraseSurface_Click(object sender, EventArgs e)
        {
            surfaceDrawer.Erase(g);
        }

        private void buttonDrawCube_Click(object sender, EventArgs e)
        {
            cubeDrawer.Draw(g);
        }

        private void buttonEraseCube_Click(object sender, EventArgs e)
        {
            cubeDrawer.Erase(g);
        }
    }
}