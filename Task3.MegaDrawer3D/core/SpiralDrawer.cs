using System;
using System.Drawing;

namespace app.core
{
    public class SpiralDrawer : Drawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public const int Width = 2;
        public readonly double X;
        public readonly double Y;
        public readonly int LoopsCount;
        public readonly double TurnWidth;
        public readonly double TurnHeight;
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

        // TODO refactor code, make clear variable names, extract hardcoded values
        // TODO make x,y real object top left coordinates
        public override void Draw(Graphics g, Color color)
        {
            var pen = new Pen(color, PenWidth);
            const double rd = 0.3535534d;
            var startPoint = new PointF((float) (X * 1f + TurnWidth), (float) (Y * 1f));
            for (var i = 0; i < LoopsCount; i++)
            {
                var t = i * Math.PI / 180.0;
                var a = 0.3 * t;
                var b = 10 * t;
                var z1 = a;
                var z2 = Math.Cos(b);
                var z3 = Math.Sin(b);
                var x = z2 - rd * z3;
                var y = z1 - rd * z3;
                var endPoint = new PointF((float) (X + TurnWidth * x), (float) (Y + TurnHeight * y));
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