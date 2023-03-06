using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectRpg.Models.Obstacles
{
    public class Obstacle : GameObject
    {
        public Obstacle(Texture2D texture, float radius, string tag, Vector2 position, Vector2 hitCenter) : base(texture, radius, tag, position, hitCenter)
        {

        }
    }

    public class Tree : Obstacle
    {
        public Tree(Texture2D texture, string tag, Vector2 position) : base(texture, 0, tag, position, Vector2.Zero)
        {
            _radius = 18;
            _hitPosBox = new Vector2(Position.X + 15, Position.Y + 100);

        }

    }

    public class Bush : Obstacle
    {
        public Bush(Texture2D texture, string tag, Vector2 position) : base(texture, 0, tag, position, Vector2.Zero)
        {
            _radius = 25;
            _hitPosBox = new Vector2(Position.X + 10, Position.Y + 5);
        }
    }
}
