using System.Drawing;

namespace WindowsFormsApp2
{
    public class CircleDrawer : IDrawer
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

        public void Draw(Graphics g) => Draw(g,DefaultColor,DefaultFillColor);

        public void Draw(Graphics g, Color color) => Draw(g,color,DefaultFillColor);

        public void Draw(Graphics g, Color color, Color fillColor)
        {
            g.FillEllipse(new SolidBrush(fillColor),X,Y,Radius,Radius);
            g.DrawEllipse(new Pen(color, Width),X,Y,Radius,Radius);
        }

        public void Erase(Graphics g) => Erase(g,Color.White);

        public void Erase(Graphics g, Color color) => g.FillEllipse(new SolidBrush(color),X-Width,Y-Width,Radius+Width*2,Radius+Width*2);
    }
}