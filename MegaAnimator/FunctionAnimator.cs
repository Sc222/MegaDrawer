using System;
using System.Drawing;

namespace MegaAnimator
{
    public class FunctionAnimator : IAnimator
    {
        private const int MaxTicks = 306;
        private const float XIncrement = 0.6f;
        private readonly Rectangle initialRectangle;
        private float initialX = 0;
        private Rectangle animatedRectangle;
        private Func<double, double> yFunction;

        public FunctionAnimator(Rectangle initialRectangle, Func<double,double> yFunction)
        {
            this.initialRectangle = initialRectangle;
            animatedRectangle = initialRectangle;
            this.yFunction = yFunction;
        }

        public bool Animate(int ticks, Graphics g)
        {
            if (ticks < MaxTicks)
            {
                g.Clear(Color.White);
                var dx = XIncrement;
                var dy = yFunction.Invoke(initialX+dx);
                initialX += dx;
                
                var r = new Rectangle(
                    (int)Math.Round(animatedRectangle.X+dx),
                    (int)Math.Round(animatedRectangle.Y+dy),
                    animatedRectangle.Width,
                    animatedRectangle.Height
                );
                animatedRectangle = r;
                g.FillRectangle(Brushes.Plum, r);
                return false;
            }
            animatedRectangle = initialRectangle;
            initialX = 0;
            return true;
        }
    }
}