using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp2
{
    public class RegularPolygonDrawer : IDrawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public static readonly Color DefaultFillColor = Color.CornflowerBlue;
        public const int Width = 5;
        public readonly int X;
        public readonly int Y;
        public readonly int Radius;
        public readonly int N;
        private PolygonDrawer polygonDrawer;

        public RegularPolygonDrawer(int x, int y, int radius, int n)
        {
            X = x;
            Y = y;
            Radius = radius;
            N = n;
            polygonDrawer = new PolygonDrawer(GeneratePoints());
        }

        private List<PointF> GeneratePoints()
        {
            var points = new List<PointF>();
            for (int i = 1; i <= N; i++)
            {
                var angle = (2 * Math.PI / N)*i;
                points.Add(new PointF((float) (X+Radius*Math.Cos(angle)),(float) (Y+Radius*Math.Sin(angle))));
            }

            return points;
        }

        public void Draw(Graphics g) => Draw(g,DefaultColor,DefaultFillColor);

        public void Draw(Graphics g, Color color) => Draw(g,color,DefaultFillColor);

        public void Draw(Graphics g, Color color, Color fillColor) => polygonDrawer.Draw(g,color,fillColor);

        public void Erase(Graphics g) => Erase(g,Color.White);

        public void Erase(Graphics g, Color color) => polygonDrawer.Erase(g,color);
    }
}