using System.Drawing;

namespace MegaAnimator
{
    public interface IAnimator
    {
        bool Animate(int ticks, Graphics g);
    }
}