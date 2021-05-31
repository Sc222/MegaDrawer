using System;
using System.Drawing;
using System.Threading;

namespace app.core
{
    public class CubeAnimationsWrapper
    {
        private const double rd = 0.3535534;
        private int n = 16;
        private double s = 1.0;
        public Point3F[] cub;
        public Point[] cubpro;
        public int Mx = 100, My = 100;
        private double a, sn = 1.0, cs;
        private const double H = Math.PI / 100;
        private double snh, csh, sna, csa;
        private Point3F z;
        private Point3F[] cubs;

        public CubeAnimationsWrapper()
        {
            cbinit();
        }

        //трехмерная точка
        public struct Point3F
        {
            public float x, y, z;

            public Point3F(float x1, float y1, float z1)
            {
                x = x1;
                y = y1;
                z = z1;
            }
        };

        //инициация точек куба
        public void cbinit()
        {
            cub = new Point3F[n];
            cub[0] = new Point3F(0, 0, 0);
            cub[1] = new Point3F(1, 0, 0);
            cub[2] = new Point3F(1, 1, 0);
            cub[3] = new Point3F(0, 1, 0);
            cub[4] = new Point3F(0, 0, 0);
            cub[5] = new Point3F(0, 0, 1);
            cub[6] = new Point3F(1, 0, 1);
            cub[7] = new Point3F(1, 0, 0);
            cub[8] = new Point3F(1, 0, 1);
            cub[9] = new Point3F(1, 1, 1);
            cub[10] = new Point3F(1, 1, 0);
            cub[11] = new Point3F(1, 1, 1);
            cub[12] = new Point3F(0, 1, 1);
            cub[13] = new Point3F(0, 1, 0);
            cub[14] = new Point3F(0, 1, 1);
            cub[15] = new Point3F(0, 0, 1);
            for (var i = 0; i < n; i++)
            {
                cub[i].z = cub[i].z * 10;
                cub[i].x = cub[i].x * 10 + Mx;
                cub[i].y = cub[i].y * 10 + My;
            }
        }

        //рисование проекций куба 
        public void ProjectCube()
        {
            int i;
            cubpro = new Point[n];
            for (i = 0; i < n; i++)
            {
                cubpro[i] = new Point();
                cubpro[i].X = (int) Math.Round(cub[i].y - rd * cub[i].z);
                cubpro[i].Y = (int) Math.Round(cub[i].x - rd * cub[i].z);
            }
        }

        //Рисовать куб
        public void DrawCube(Graphics gcb, Pen pn)
        {
            int i;
            int px0, py0, px, py;
            px0 = cubpro[0].X;
            py0 = cubpro[0].Y;
            for (i = 0; i < 16; i++)
            {
                px = cubpro[i].X;
                py = cubpro[i].Y;
                gcb.DrawLine(pn, px0, py0, px, py);
                px0 = px;
                py0 = py;
            }
        }

        public void ScaleCube(float s)
        {
            var zf = new Point3F(Mx, My, 0);
            for (var i = 0; i < n; i++)
            {
                cub[i].x = cub[i].x * s + zf.x * (1 - s);
                cub[i].y = cub[i].y * s + zf.y * (1 - s);
                cub[i].z = cub[i].z * s;
            }
        }

        //смещение по оси Z
        public void TranslateCube(float dz)
        {
            for (var i = 0; i < n; i++) cub[i].z += dz;
        }

        public void AnimateCubeScaling(Graphics g)
        {
            cbinit();
            s = 1;
            var clr = Color.Red;
            const int pause = 100;
            while (s <= 1.6)
            {
                g.Clear(Color.White);
                ProjectCube();
                ScaleCube((float) s);
                DrawCube(g, new Pen(clr, 1));
                s += 0.1;
                Thread.Sleep(pause);
            }
            while (s >= 0)
            {
                g.Clear(Color.White);
                ProjectCube();
                ScaleCube((float) s);
                DrawCube(g, new Pen(clr, 1));
                s -= 0.1;
                Thread.Sleep(pause);
            }
            g.Clear(Color.White);
        }

        public void AnimateCubeTranslation(Graphics g)
        {
            cbinit();
            var clr = Color.Red;
            var pause = 50;
            for (var i = 0; i < 30; i++)
            {
                g.Clear(Color.White);
                ProjectCube();
                DrawCube(g, new Pen(clr, 1));
                Thread.Sleep(pause);
                TranslateCube(5);
            }
            for (var i = 0; i < 30; i++)
            {
                g.Clear(Color.White);
                ProjectCube();
                DrawCube(g, new Pen(clr, 1));
                Thread.Sleep(pause);
                TranslateCube(-5);
            }
            g.Clear(Color.White);
        }
        
        private void ApplyCubeRotation(double sn, double cs) {
            for (int i = 0; i < n; i++)
            {
                cubs[i].x = (float)(z.x + (cub[i].x - z.x) * cs - (cub[i].y - z.y) * sn);
                cubs[i].y = (float)(z.y + (cub[i].y - z.y) * cs - (cub[i].x - z.x) * sn);
                cubs[i].z = cub[i].z;
            }
        }

        public void AnimateCubeRotation(Graphics g)
        {
            snh = Math.Sin(H);
            csh = Math.Cos(H);
            a = 0;
            cs = Math.Cos(a);
            sn = Math.Sin(a);
            z = new Point3F(cub[0].x,cub[0].y, 0);
            cs = Math.Cos(a);
            sn = Math.Sin(a);
            cubs=new Point3F[n];
            cubpro = new Point[n];
            for (var i = 0; i < n; i++) cubs[i] = new Point3F(0,0,0); 
            Color clr;
            var pause = 50;
            var k = 0;
            while (true)
            {
                if (a >=  Math.PI) break;
                if ((k % 2) == 0) clr = Color.White;
                else clr = Color.Red;
                k++;
                ApplyCubeRotation(sn, cs);
                for (var i = 0; i < n; i++) {
                    cubpro[i].X = (int)Math.Round(cubs[i].y - rd * cubs[i].z);
                    cubpro[i].Y = (int)Math.Round(cubs[i].x - rd * cubs[i].z);
                }
                DrawCube(g, new Pen(clr, 1));
                Thread.Sleep(pause);
                cs = cs * csh - sn * snh; sn = cs * snh + sn * csh; a = a + H;
                g.Clear(Color.White);
            }
        }
    }
}