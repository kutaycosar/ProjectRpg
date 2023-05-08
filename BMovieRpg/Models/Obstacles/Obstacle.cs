using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Models.Physics;
using ProjectRpg.Structs;
using System;


namespace ProjectRpg.Models.Obstacles
{
    public class Obstacle : GameObject, ICollidable
    {
        protected Data.PhyscData physcData;
        public Obstacle(Texture2D texture, string tag, Vector2 pos) : base(texture, tag, pos)
        {
            physcData.Scale = 0.6f;
        }

        public float Scale { get { return physcData.Scale; } set { physcData.Scale = value; } }

        public bool DidCollide(ICollidable callerObj, ICollidable otherObj)
        {
            throw new NotImplementedException();
        }

        public void OnCollision()
        {
            throw new NotImplementedException();
        }
    }

    public class Tree : Obstacle
    {
        public Tree(Texture2D texture, string tag, Vector2 pos) : base(texture, tag, pos)
        {
            

        }

    }

    public class Bush : Obstacle
    {
        public Bush(Texture2D texture, string tag, Vector2 pos) : base(texture, tag, pos)
        {
            offSetData.Width = 10;
            offSetData.Height = 10;
        }
    }
}
