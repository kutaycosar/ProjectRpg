using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Structs;
using System;


namespace ProjectRpg.Models.Obstacles
{
    public class Obstacle : GameObject, ICollidable
    {
        protected Data.PhyscData physcData;
        public Obstacle(Texture2D texture, string tag, Vector2 position) : base(texture, tag, position)
        {

        }

        public float Radius { get { return physcData.Radius; } set { physcData.Radius = value; } }
        public Vector2 HitBoxPos { get { return physcData.HitBoxPos; } set { physcData.HitBoxPos = value; } }

        public void OnCollision()
        {
            throw new NotImplementedException();
        }
    }

    public class Tree : Obstacle
    {
        public Tree(Texture2D texture, string tag, Vector2 position) : base(texture, tag, position)
        {
            Radius = 18;
            HitBoxPos = new Vector2(Position.X + 15, Position.Y + 100);

        }

    }

    public class Bush : Obstacle
    {
        public Bush(Texture2D texture, string tag, Vector2 position) : base(texture, tag, position)
        {
            Radius = 25;
            HitBoxPos = new Vector2(Position.X + 10, Position.Y + 5);
        }
    }
}
