using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Managers;
using System;

namespace ProjectRpg.Models.Characters
{
    public class Monster : Character, IMovable, ICollidable
    {
        protected Direction _direction;
        
        public Monster(Texture2D texture, string tag, Vector2 position) : base(texture, 0, tag, position, Vector2.Zero)
        {
            _isMoving = true;
            _speed = 200;
            _radius = 56;
            _hitPosBox = new Vector2(Position.X + 29, Position.Y + 31);

        }

        public void SetDirection(Direction direction)
        {
            _direction = direction;
        }

        public override void Move()
        {

            if (PlayerInputManager.Direction != Direction.None)
            {
                //Vector2 dir = Vector2.Normalize(PlayerInputManager.Direction);
                Vector2 dir = PlayerInputManager.Direction switch
                {
                    Direction.Left => new Vector2(0, -1),
                    Direction.Top => new Vector2(-1, 0),
                    Direction.Right => new Vector2(0, 1),
                    Direction.Bottom => new Vector2(+1, 0),
                };
                if (_isMoving == true)
                {
                    _lastPosition = Position;
                    Position += dir * Speed * Globals.TotalSeconds;
                }

            }
        }

        public override void Update()
        {
            OnCollision();

            HitPosBox = new Vector2(Position.X + 29, Position.Y + 31);

            Move();
        }

        public override void OnCollision()
        {
            _isMoving = CollisionManager.DidCollide(this);
            if (!_isMoving) this.Position = LastPosition;
        }
    }
}
