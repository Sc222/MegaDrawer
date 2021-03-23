using System;
using System.Collections.Generic;
using System.Drawing;

namespace WindowsFormsApp2
{
    public abstract class Drawer
    {
        public abstract void Draw(Graphics g);
        public abstract void Draw(Graphics g, Color color);
        public abstract void Draw(Graphics g, Color color, Color fillColor);
        public abstract void Erase(Graphics g);
        public abstract void Erase(Graphics g, Color color);

        public static Dictionary<Type, Drawer> InitDrawersDictionary()
        {
            return new Dictionary<Type, Drawer>
            {
                {typeof(LineDrawer),null},
                {typeof(CircleDrawer),null},
                {typeof(PolygonDrawer),null},
                {typeof(RegularPolygonDrawer),null}
            };
        }
    }
}