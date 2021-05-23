using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class PolygonDrawer : Drawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public static readonly Color DefaultFillColor = Color.CornflowerBlue;
        public const int Width = 5;
        private List<PointF> points = new List<PointF>();

        public PolygonDrawer()
        {
        }

        public PolygonDrawer(List<PointF> points) => this.points = points;

        public void SetPoints(List<PointF> points) => this.points = points;

        public override void Draw(Graphics g) => Draw(g,DefaultColor,DefaultFillColor);

        public override void Draw(Graphics g, Color color) => Draw(g,color,DefaultFillColor);

        public override void Draw(Graphics g, Color color, Color fillColor)
        {
            g.FillPolygon(new SolidBrush(fillColor),points.ToArray());
            g.DrawPolygon(new Pen(color, Width),points.ToArray());
        }

        public override void Erase(Graphics g) => Erase(g, Color.White);

        public override void Erase(Graphics g, Color color) => Draw(g, color, color);
    }
}