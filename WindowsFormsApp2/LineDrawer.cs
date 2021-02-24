using System.Drawing;

namespace WindowsFormsApp2
{
    public class LineDrawer : IDrawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public readonly int X1;
        public readonly int Y1;
        public readonly int X2;
        public readonly int Y2;
        public readonly int Width;

        public LineDrawer(int x1, int y1, int x2, int y2, int width)
        {
           X1 = x1;
           Y1 = y1;
           X2 = x2;
           Y2 = y2;
           Width = width;
        }

        public void Draw(Graphics g) => Draw(g,DefaultColor);

        public void Draw(Graphics g, Color color) => g.DrawLine(new Pen(color, Width),X1,Y1,X2,Y2);

        public void Draw(Graphics g, Color color, Color fillColor) => Draw(g, color);

        public void Erase(Graphics g) => Erase(g,Color.White);

        public void Erase(Graphics g, Color color) => g.DrawLine(new Pen(color, Width), X1, Y1, X2, Y2);
    }
}