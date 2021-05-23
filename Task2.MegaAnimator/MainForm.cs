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

        private Rectangle currentRectangle = new Rectangle(0, 0, 0, 0);
        private FunctionAnimator functionAnimator = new FunctionAnimator(new Rectangle(0, 100, 30, 30), (x)=>Math.Cos(x)*5);
        private RotateAnimator rotateAnimator = new RotateAnimator();
        private ScaleAnimator scaleIncreaseAnimator = new ScaleAnimator(2, new Rectangle(0, 0, 0, 0));
        private ScaleAnimator scaleDecreaseAnimator = new ScaleAnimator(-2, new Rectangle(0, 0, 200, 200));

        public MainForm() => InitializeComponent();

        private void StartTimer(EventHandler tickHandler, int interval = Interval)
        {
            if (timer.Enabled)
                return;
            timer = new Timer {Interval = interval};
            timer.Tick += tickHandler;
            timer.Start();
        }

        private void StopTimer()
        {
            ticks = 0;
            timer.Stop();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            AllocConsole();
            g = panelDrawCanvas.CreateGraphics();
            g.SmoothingMode = SmoothingMode.HighQuality;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            DoubleBuffered = true;
        }

        //handler for scale up event
        private void TimerScaleUpTick(object sender, EventArgs e)
        {
            var isFinished = scaleIncreaseAnimator.Animate(ticks, g);
            if (isFinished)
            {
                StopTimer();
                StartTimer(TimerScaleDownTick);
            }
            else
                ticks++;
        }

        //handler for scale down event
        private void TimerScaleDownTick(object sender, EventArgs e)
        {
            var isFinished = scaleDecreaseAnimator.Animate(ticks, g);
            if (isFinished)
                StopTimer();
            else
                ticks++;
        }

        //handler for rotating event
        private void TimerRotateTick(object sender, EventArgs e)
        {
            var isFinished = rotateAnimator.Animate(ticks, g);
            if (isFinished)
                StopTimer();
            else
                ticks++;
        }
        
        //handler for function moving event
        private void TimerFunctionMoveTick(object sender, EventArgs e)
        {
            var isFinished = functionAnimator.Animate(ticks, g);
            if (isFinished)
                StopTimer();
            else
                ticks++;
        }


        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void buttonScale_Click(object sender, EventArgs e)
        {
            StartTimer(TimerScaleUpTick);
        }

        private void buttonRotate_Click(object sender, EventArgs e)
        {
            StartTimer(TimerRotateTick);
        }

        private void buttonMoveByFunction_Click(object sender, EventArgs e)
        {
            StartTimer(TimerFunctionMoveTick);
        }
    }
}