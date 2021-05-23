using System;
using System.Drawing;

namespace MegaAnimator
{
    public class ScaleAnimator : IAnimator
    {
        private const int MaxTicks = 100;
        private readonly float sizeChange;
        private Rectangle animatedRectangle;
        private Rectangle initialRectangle;
        
        public ScaleAnimator(int sizeChange, Rectangle initialRectangle)
        {
            this.sizeChange = sizeChange;
            this.initialRectangle = initialRectangle;
            animatedRectangle = initialRectangle;
        }

        public bool Animate(int ticks, Graphics g)
        {
            if (ticks < MaxTicks)
            {
                g.Clear(Color.White);
                var r = new Rectangle(
                    (int) Math.Round(150 - (animatedRectangle.Width + sizeChange) / 2f),
                    (int) Math.Round(100 - (animatedRectangle.Height + sizeChange) / 2f),
                    (int) Math.Round(animatedRectangle.Width + sizeChange),
                    (int) Math.Round(animatedRectangle.Height + sizeChange));
                animatedRectangle = r;
                g.FillRectangle(Brushes.Teal, r);
                return false;
            }
            animatedRectangle = initialRectangle;
            return true;
        }
    }
}