using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using ProjectRpg.Structs;

namespace ProjectRpg.Models
{
    public class DynGameObject : GameObject, IMovable
    {
        protected Data.MoveData moveData;
        
        public DynGameObject(Texture2D texture, string tag, Vector2 position) : base(texture, tag, position)
        {
            this.moveData.Direction = Direction.None;
            this.moveData.IsMoving = true;
        }

        public bool IsMoving { get { return moveData.IsMoving; } protected set { moveData.IsMoving = value; } }
        public int Speed { get { return moveData.Speed; } protected set { moveData.Speed = value; } }
        public Direction Direction { get { return moveData.Direction; } protected set { moveData.Direction = value; } }

        public virtual void Move()
        {
            throw new NotImplementedException();
        }

        public virtual void Update()
        {
            throw new NotImplementedException();
        }
    }
}
