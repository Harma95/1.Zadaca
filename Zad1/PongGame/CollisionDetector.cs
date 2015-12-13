using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PongGame
{
    class CollisionDetector
    {
        public static bool Overlaps(Sprite s1, Sprite s2)
        {
            if (((s1.Position.X > s2.Position.X) && (s1.Position.X <s2.Position.X +s2.Size.Width))&&(s1.Position.Y<20||s1.Position.Y>840))
            {
                return true;
            }
            return false;
        }
    }
}
