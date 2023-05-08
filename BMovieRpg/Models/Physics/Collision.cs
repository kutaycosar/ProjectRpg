using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg.Models.Physics
{
    public static class Collision // change to proper rectangle collision
    {
        //public static bool CircleCollision(ICollidable callerObj, ICollidable otherObj, float margin)
        //{
        //    float distance = Vector2.Distance(callerObj.Pos, otherObj.Pos);
        //    float combined = callerObj.Radius + otherObj.Radius;

        //    return (distance - margin < combined);
        //}

        public static bool RectCollision(ICollidable r1, ICollidable r2)
        {
            // Calculate the bounds of the first rectangle
            float r1Left = r1.Pos.X - ((r1.Width * r1.Scale) / 2) + r1.OffSetX;
            float r1Right = r1.Pos.X + ((r1.Width * r1.Scale) / 2) + r1.OffSetX;
            float r1Top = r1.Pos.Y - ((r1.Width * r1.Scale) / 2) + r1.OffSetY;
            float r1Bottom = r1.Pos.Y + ((r1.Width * r1.Scale) / 2) + r1.OffSetY;

            // Calculate the bounds of the second rectangle with offsets
            float r2Left = r2.Pos.X - ((r2.Width * r2.Scale) / 2) + r2.OffSetX;
            float r2Right = r2.Pos.X + ((r2.Width * r2.Scale) / 2) + r2.OffSetX;
            float r2Top = r2.Pos.Y - ((r2.Width * r2.Scale) / 2) + r2.OffSetY;
            float r2Bottom = r2.Pos.Y + ((r2.Width * r2.Scale) / 2) + r2.OffSetY;

            // Check for overlap on the X axis
            if (r1Right < r2Left || r2Right < r1Left)
            {
                // No overlap on X axis
                return false;
            }

            // Check for overlap on the Y axis
            if (r1Bottom < r2Top || r2Bottom < r1Top)
            {
                // No overlap on Y axis
                return false;
            }

            // Overlap on both X and Y axis, there is a collision
            return true;
        }
    }
}
