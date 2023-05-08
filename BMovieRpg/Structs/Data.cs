using Microsoft.Xna.Framework;
using System.Collections.Generic;


namespace ProjectRpg.Structs
{
    public struct Data
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
            public float Scale;
        }

        public struct SizeData
        {
            public int Width;
            public int Height;
        }
    }
   

}
