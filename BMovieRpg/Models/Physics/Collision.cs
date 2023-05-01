using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg.Models.Physics
{
    public static class Collision
    {
        public static bool CircleCollision(float distance, float combinedRadius)
        {
            return (distance < combinedRadius);
        }
    }
}
