using System.Drawing;

namespace WindowsFormsApp2
{
    public interface IDrawer
    {
        void Draw(Graphics g);
        void Draw(Graphics g, Color color);
        void Draw(Graphics g, Color color, Color fillColor);
        void Erase(Graphics g);
        void Erase(Graphics g, Color color);
    }
}