using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace MegaAnimator
{
    public partial class FormMain : Form
    {
        private Graphics g;
        
        public FormMain() => InitializeComponent();

        private void FormMain_Load(object sender, EventArgs e)
        {
            AllocConsole();
            g = panelDrawCanvas.CreateGraphics();
        }
        
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        
    }
}