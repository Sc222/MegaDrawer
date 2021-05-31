using System;
using System.Collections.Generic;
using System.Drawing;

namespace Task4.MegaFractal.core
{
    public class SnowflakeDrawer
    {
        // начальные координаты
        private List<PointF> _initiator;

        // углы и расстояния до генератора
        private float _scaleFactor;
        private List<float> _generatorDTheta;
        
        // вход в рекурсию
        private void DrawSnowflake(Graphics g, int depth)
        {
            g.Clear(Color.White);
            for (var i = 1; i < _initiator.Count; i++)
            {
                var p1 = _initiator[i - 1];
                var p2 = _initiator[i];
                var dx = p2.X - p1.X;
                var dy = p2.Y - p1.Y;
                var length = (float) Math.Sqrt(dx * dx + dy * dy);
                var theta = (float) Math.Atan2(dy, dx);
                DrawSnowflakeEdge(g, depth, ref p1, theta, length);
            }
        }

        // рекурсивный метод отрисовки снежинки
        private void DrawSnowflakeEdge(Graphics gr, int depth, ref PointF p1, float theta, float dist)
        {
            if (depth == 0)
            {
                var p2 = new PointF(
                    (float) (p1.X + dist * Math.Cos(theta)),
                    (float) (p1.Y + dist * Math.Sin(theta)));
                gr.DrawLine(Pens.Blue, p1, p2);
                p1 = p2;
                return;
            }
            dist *= _scaleFactor;
            foreach (var t in _generatorDTheta)
            {
                theta += t;
                DrawSnowflakeEdge(gr, depth - 1, ref p1, theta, dist);
            }
        }

        public void Draw(Graphics graphics, int picCanvasWidth, int canvasHeight, string txtDepthText)
        {
            _initiator = new List<PointF>();
            var height = 0.75f * (Math.Min(
                picCanvasWidth,
                canvasHeight) - 20);
            var width = (float) (height / Math.Sqrt(3.0) * 2);
            var y3 = canvasHeight - 10;
            var y1 = y3 - height;
            var x3 = canvasHeight / 2;
            var x1 = x3 - width / 2;
            var x2 = x1 + width;
            _initiator.Add(new PointF(x1, y1));
            _initiator.Add(new PointF(x2, y1));
            _initiator.Add(new PointF(x3, y3));
            _initiator.Add(new PointF(x1, y1));
            _scaleFactor = 1 / 3f;
            _generatorDTheta = new List<float>();
            var piOverThree = (float) (Math.PI / 3f);
            _generatorDTheta.Add(0);
            _generatorDTheta.Add(-piOverThree);
            _generatorDTheta.Add(2 * piOverThree);
            _generatorDTheta.Add(-piOverThree);
            var depth = 0;
            var isSuccess = int.TryParse(txtDepthText, out depth);
            if (!isSuccess || depth < 0 || depth>6)
                return;
            DrawSnowflake(graphics, depth);
        }
    }
}