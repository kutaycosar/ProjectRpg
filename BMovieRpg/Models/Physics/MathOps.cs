using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg.Models.Physics
{
    public static class MathOps
    {
        public static int RectRadius(int x, int y)
        {
            return (x + y) / 2;
        }
    }
}
