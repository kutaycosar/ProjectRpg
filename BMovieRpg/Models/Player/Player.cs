using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;

namespace ProjectRpg
{
    public class Player : GameObject,IAnimated, IMovable, ICollidable
    {
        private int _speed;
        private bool _isMoving;

        public Player(Texture2D texture, float rotation, string tag, Vector2 position, int speed) : base(texture, rotation, tag, position)
        {
            _speed = speed;
        }

        public int Speed {get { return _speed; }set { _speed = value; }}

        public bool IsMoving { get { return IsMoving; } set { _isMoving = value; } }

        public List<Texture2D> Animations { get; set; }

        public void Move()
        {
            if (InputManager.Direction != Vector2.Zero)
            {
                Vector2 dir = Vector2.Normalize(InputManager.Direction);
                Position += dir * Speed * Globals.TotalSeconds;
            }
        }

        public void OnCollision(GameObject other)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            Move();
        }
    }
}
