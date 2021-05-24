using System;
using System.Drawing;

namespace app.core
{
    public class SpiralDrawer : Drawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public const int Width = 2;
        public readonly int X;
        public readonly int Y;
        public readonly int LoopsCount;
        public readonly int TurnWidth;
        public readonly int TurnHeight;
        public readonly int PenWidth;

        public SpiralDrawer(int x, int y, int loopsCount, int turnWidth, int turnHeight, int penWidth = Width)
        {
            X = x;
            Y = y;
            LoopsCount = loopsCount;
            TurnWidth = turnWidth;
            TurnHeight = turnHeight;
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
            var px0 = X * 1f + TurnWidth;
            var py0 = Y * 1f;
            for (var i = 0; i <= LoopsCount; i++)
            {
                t = i * Math.PI / 180.0;
                a = 0.3 * t;
                b = 10 * t;
                z1 = a;
                z2 = Math.Cos(b);
                z3 = Math.Sin(b);
                x = z2 - rd * z3;
                y = z1 - rd * z3;
                var px = (float) (X + TurnWidth * x);
                var py = (float) (Y + TurnHeight * y);
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
            var spiralDrawer = new SpiralDrawer(X, Y, LoopsCount, TurnWidth, TurnHeight, PenWidth * 2);
            for (var i = 0; i < PenWidth / 2; i++) spiralDrawer.Draw(g, color, color);
        }
    }
}