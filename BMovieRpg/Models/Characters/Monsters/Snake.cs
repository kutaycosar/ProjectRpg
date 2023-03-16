using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg.Models.Characters.Monsters
{
    public class Snake : Monster, IMovable, ICollidable, IAnimated
    {
        public Snake(Texture2D texture, string tag, Vector2 position)
            : base(texture, tag, position, 0)
        {
            _direction = Direction.None;
            _speed = 200;
            _radius = 56;
            _hitPosBox = new Vector2(Position.X + 29, Position.Y + 31);
            _lastPosition = Position;
        }
    }
}
