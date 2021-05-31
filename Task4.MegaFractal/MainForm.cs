using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Task4.MegaFractal.core;

namespace Task4.MegaFractal
{
    public partial class MainForm : Form
    {
        private Graphics g;
        private SnowflakeDrawer snowflakeDrawer = new SnowflakeDrawer();
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            g = picCanvas.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            DoubleBuffered = true;
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            snowflakeDrawer.Draw(g, picCanvas.ClientSize.Width,picCanvas.ClientSize.Height, txtDepth.Text);
        }
    }
}