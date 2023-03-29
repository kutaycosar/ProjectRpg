using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg.Structs
{

    public struct PosData
    {
        public Vector2 Pos;  
        public Vector2 LastPos;
        public Vector2 CurrentPos;
    }

    public struct MoveData
    {
        public Direction Direction;
        public bool IsMoving;
        public int Speed;
    }

    public struct PhyscData
    {
        public float Radius;
        public Vector2 HitBoxPos;
    }

    public struct SizeData
    {
        public int Width;
        public int Height;
    }
}
