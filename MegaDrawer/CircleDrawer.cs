using System.Drawing;

namespace WindowsFormsApp2
{
    public class CircleDrawer : Drawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public static readonly Color DefaultFillColor = Color.CornflowerBlue;
        public const int Width = 5;
        public readonly int X;
        public readonly int Y;
        public readonly int Radius;

        public CircleDrawer(int x, int y, int radius)
        {
           X = x;
           Y = y;
           Radius = radius;
        }

        public override void Draw(Graphics g) => Draw(g,DefaultColor,DefaultFillColor);

        public override void Draw(Graphics g, Color color) => Draw(g,color,DefaultFillColor);

        public override void Draw(Graphics g, Color color, Color fillColor)
        {
            g.FillEllipse(new SolidBrush(fillColor),X,Y,Radius,Radius);
            g.DrawEllipse(new Pen(color, Width),X,Y,Radius,Radius);
        }

        public override void Erase(Graphics g) => Erase(g,Color.White);

        public override void Erase(Graphics g, Color color) => Draw(g, color, color);
    }
}