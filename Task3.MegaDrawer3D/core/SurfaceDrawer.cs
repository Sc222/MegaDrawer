using System;
using System.Drawing;

namespace app.core
{
    public class SurfaceDrawer : Drawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public const int Width = 2;
        public readonly double X;
        public readonly double Y;
        public readonly double Z3Start;
        public readonly double Z3End;
        public readonly double Z3Step;
        public readonly double Z2Start;
        public readonly double Z2End;
        public readonly double Z2Step;
        public readonly double XStepWidth;
        public readonly double YStepWidth;
        public readonly int PenWidth;
        
        public SurfaceDrawer(
            double x, double y,
            double z3Start, double z3End, double z3Step,
            double z2Start, double z2End, double z2Step,
            double xStepWidth, double yStepWidth,
            int penWidth = Width)
        {
            X = x;
            Y = y;
            Z3Start = z3Start;
            Z3End = z3End;
            Z3Step = z3Step;
            Z2Start = z2Start;
            Z2End = z2End;
            Z2Step = z2Step;
            XStepWidth = xStepWidth;
            YStepWidth = yStepWidth;
            PenWidth = penWidth;
        }
        
        public override void Draw(Graphics g)
        {
            Draw(g, DefaultColor);
        }

        private PointF GetNextPoint(double z2, double z3)
        {
            const double rd = 0.3535534d;
            var z1 = 2 * Math.Exp(-z2 * z2 - z3 * z3);
            return new PointF((float) (X + XStepWidth * z2 - (rd * XStepWidth) * z3), (float) (Y + YStepWidth * z1 - (rd * YStepWidth) * z3));
        }

        // TODO refactor code, make clear variable names, extract hardcoded values
        // TODO make x,y real object top left coordinates
        public override void Draw(Graphics g, Color color)
        {
            var pen = new Pen(color, PenWidth);
            var z3 = Z3Start;
            while (z3 <= Z3End)
            {
                var z2 = Z2Start;
                var startPoint = GetNextPoint(z2, z3);
                while (z2 <= Z2End)
                {
                    var nextPoint = GetNextPoint(z2, z3);
                    g.DrawLine(pen, startPoint, nextPoint);
                    z2 += Z2Step;
                    startPoint = nextPoint;
                }

                z3 += Z3Step;
            }
        }

        public override void Draw(Graphics g, Color color, Color fillColor)
        {
            Draw(g, color);
        }

        public override void Erase(Graphics g) => Erase(g, Color.White);

        // default Draw doesn't delete everything
        public override void Erase(Graphics g, Color color)
        {
            //TODO: erase using spiral drawer with different size
            g.Clear(color);
        }
    }
}