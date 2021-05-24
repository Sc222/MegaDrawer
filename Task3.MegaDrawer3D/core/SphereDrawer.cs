using System;
using System.Drawing;

namespace app.core
{
    public class SphereDrawer : Drawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public const int Width = 2;
        public readonly int X;
        public readonly int Y;
        public readonly int LoopsCount;
        public readonly int SphereSize;
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

        // TODO refactor code, make clear variable names
        // TODO make x,y real spiral top left coordinates
        public override void Draw(Graphics g, Color color)
        {
            var pen = new Pen(color, PenWidth);
            const double rd = 0.3535534d;
            double x, y, t, a, b, z1, z2, z3;
            float px, py;
            float px0 = 0, py0 = 0;
            for (var i = 0; i <= LoopsCount; i++)
            {
                t = i * Math.PI / 180.0;
                a = (float) 0.3 * t;
                b = (float) 10 * t;
                z1 = (float) Math.Sin(b);
                z2 = (float) Math.Cos(b) * (float) Math.Cos(a);
                z3 = (float) Math.Cos(b) * (float) Math.Sin(a);
                x = z2 - rd * z3;
                y = z1 - rd * z3;
                px = (float) (X + SphereSize * x);
                py = (float) (Y + SphereSize * y);
                if (i == 0)
                {
                    px0 = px;
                    py0 = py;
                }

                g.DrawLine(pen, px0, py0, px, py);
                px0 = px;
                py0 = py;
            }
        }

        public override void Draw(Graphics g, Color color, Color fillColor) => Draw(g, color);

        public override void Erase(Graphics g) => Erase(g, Color.White);

        // default Draw doesn't delete everything, so we call draw with bigger width and call it multiple times
        public override void Erase(Graphics g, Color color)
        {
            var sphereDrawer = new SphereDrawer(X, Y, LoopsCount, SphereSize, PenWidth * 2);
            for (var i = 0; i < PenWidth / 2; i++) sphereDrawer.Draw(g, color, color);
        }
    }
}