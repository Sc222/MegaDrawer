using System;
using System.Collections.Generic;
using System.Drawing;

namespace MegaAnimator
{
    public class RotateAnimator : IAnimator
    {
        private const double MaxRotateTicks = 360;
        
        public bool Animate(int ticks, Graphics g)
        {
            if (ticks < MaxRotateTicks)
            {
                g.Clear(Color.White);
                var angle = ((2 * Math.PI) / MaxRotateTicks) * ticks + Math.PI / 4;
                var points = new List<PointF>();
                for (var i = 0; i < 4; i++)
                {
                    points.Add(new PointF(
                        (float) (150 + 25 * Math.Cos(angle + (Math.PI / 2 * i))),
                        (float) (100 + 25 * Math.Sin(angle + (Math.PI / 2 * i))))
                    );
                }
                g.FillPolygon(Brushes.Coral, points.ToArray());
                return false;
            }
            return true;
        }
    }
}