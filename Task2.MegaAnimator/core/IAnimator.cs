using System.Drawing;

namespace MegaAnimator
{
    //TODO !!! ADD POSSIBILITY TO ANIMATE EVERY IDRAWER OBJECT (OR CREATE ANIMATEDDRAWER classes)
    public interface IAnimator
    {
        bool Animate(int ticks, Graphics g);
    }
}