using System.Drawing;

namespace app.core
{
    //TODO !!! ADD POSSIBILITY TO ANIMATE EVERY IDRAWER OBJECT (OR CREATE ANIMATEDDRAWER classes)
    public interface IAnimator
    {
        bool Animate(int ticks, Graphics g);
    }
}