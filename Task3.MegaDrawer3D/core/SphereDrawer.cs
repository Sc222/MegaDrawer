using System;
using System.Drawing;

namespace app.core
{
    public class SphereDrawer : Drawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public const int Width = 2;
        public readonly double X;
        public readonly double Y;
        public readonly int LoopsCount;
        public readonly double SphereSize;
        public readonly int PenWidth;

        public SphereDrawer(int x, int y, int loopsCount, int sphereSize, int penWidth = Width)
        {
            X = x;
            Y = y;
            LoopsCount = loopsCount;
            SphereSize = sphereSize;
            PenWidth = penWidth;
        }

        public override void Draw(Graphics g) => Draw(g, DefaultColor);

        // TODO refactor code, make clear variable names, extract hardcoded values
        // TODO make x,y real object top left coordinates
        public override void Draw(Graphics g, Color color)
        {
            var pen = new Pen(color, PenWidth);
            const double rd = 0.3535534d;
            var startPoint = new PointF(0, 0);
            for (var i = 0; i < LoopsCount; i++)
            {
                var t = i * Math.PI / 180.0;
                var a = 0.3 * t;
                var b = 10 * t;
                var z1 = Math.Sin(b);
                var z2 = Math.Cos(b) * Math.Cos(a);
                var z3 = Math.Cos(b) * Math.Sin(a);
                var x = z2 - rd * z3;
                var y = z1 - rd * z3;
                var endPoint = new PointF((float) (X + SphereSize * x), (float) (Y + SphereSize * y));
                if (i == 0)
                    startPoint = endPoint;
                g.DrawLine(pen, startPoint, endPoint);
                startPoint = endPoint;
            }
        }

        public override void Draw(Graphics g, Color color, Color fillColor) => Draw(g, color);

        public override void Erase(Graphics g) => Erase(g, Color.White);

        // default Draw doesn't delete everything
        public override void Erase(Graphics g, Color color)
        {
            //TODO: erase using spiral drawer with different size
            g.Clear(color);
        }
    }
}