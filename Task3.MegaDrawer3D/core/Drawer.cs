using System;
using System.Collections.Generic;
using System.Drawing;

namespace app.core
{
    public abstract class Drawer
    {
        public abstract void Draw(Graphics g);
        public abstract void Draw(Graphics g, Color color);
        public abstract void Draw(Graphics g, Color color, Color fillColor);
        public abstract void Erase(Graphics g);
        public abstract void Erase(Graphics g, Color color);
    }
}