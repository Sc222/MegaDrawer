using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace app.core
{
    public class CubeDrawer : Drawer
    {
        public static readonly Color DefaultColor = Color.Coral;
        public const int Width = 2;
        public readonly double X;
        public readonly double Y;
        public readonly double SideLength;
        public readonly int PenWidth;
        private const int SidesCount = 16;
        private const double rd = 0.3535534;

        public CubeDrawer(int x, int y, int sideLength, int penWidth = Width)
        {
            X = x;
            Y = y;
            SideLength = sideLength;
            PenWidth = penWidth;
        }

        public struct Point3D
        {
            public double X { get; set; }
            public double Y { get; set; }
            public double Z { get; set; }

            public Point3D(double x, double y, double z)
            {
                X = x;
                Y = y;
                Z = z;
            }
        };

        public static Point3D[] CreateCube(double sideLength, double startX, double startY)
        {
            // var cube = new List<Point3D>();
            // for (var x = 0; x < 2; x++)
            // for (var y = 0; x < 2; x++)
            // for (var z = 0; x < 2; x++)
            //     cube.Add(new Point3D(x, y, z));
            var cube = new Point3D[SidesCount];
            cube[0] = new Point3D(0, 0, 0);
            cube[1] = new Point3D(1, 0, 0);
            cube[2] = new Point3D(1, 1, 0);
            cube[3] = new Point3D(0, 1, 0);
            cube[4] = new Point3D(0, 0, 0);
            cube[5] = new Point3D(0, 0, 1);
            cube[6] = new Point3D(1, 0, 1);
            cube[7] = new Point3D(1, 0, 0);
            cube[8] = new Point3D(1, 0, 1);
            cube[9] = new Point3D(1, 1, 1);
            cube[10] = new Point3D(1, 1, 0);
            cube[11] = new Point3D(1, 1, 1);
            cube[12] = new Point3D(0, 1, 1);
            cube[13] = new Point3D(0, 1, 0);
            cube[14] = new Point3D(0, 1, 1);
            cube[15] = new Point3D(0, 0, 1);

            for (var i = 0; i < cube.Length; i++)
            {
                cube[i].X = cube[i].X * sideLength + startX;
                cube[i].Y = cube[i].Y * sideLength + startY;
                cube[i].Z *= sideLength;
            }

            return cube;
        }

        public static PointF[] ProjectCube(IEnumerable<Point3D> cubePoints)
        {
            return cubePoints.Select(p => new PointF
            {
                X = (int) Math.Round(p.X - rd * (float) p.Z),
                Y = (int) Math.Round(p.Y - rd * (float) p.Z)
            }).ToArray();
        }

        public override void Draw(Graphics g) => Draw(g, DefaultColor);

        // TODO refactor code, make clear variable names, extract hardcoded values
        // TODO make x,y real object top left coordinates
        public override void Draw(Graphics g, Color color)
        {
            var pen = new Pen(color, PenWidth);
            var cube = CreateCube(SideLength, X, Y);
            var projectedCube = ProjectCube(cube);
            var startPoint = projectedCube[0];
            for (var ii = 0; ii < 16; ii++)
            {
                var endPoint = projectedCube[ii];
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