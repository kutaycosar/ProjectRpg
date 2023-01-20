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
        public AnimationManager AnimationManager { get; set; }
        public Player(Texture2D texture, float rotation, string tag, Vector2 position, int speed) : base(texture, rotation, tag, position)
        {
            _speed = speed;
            AnimationManager = new AnimationManager(new AnimatedSprite[4]);
        }

        public int Speed {get { return _speed; }set { _speed = value; }}

        public bool IsMoving { get { return IsMoving; } set { _isMoving = value; } }

        public void Move()
        {
            if (PlayerInputManager.Direction != Direction.None)
            {
                //Vector2 dir = Vector2.Normalize(PlayerInputManager.Direction);
                Vector2 dir = PlayerInputManager.Direction switch
                {
                    Direction.Top => new Vector2(0, -1),
                    Direction.Left => new Vector2(-1, 0),
                    Direction.Bottom => new Vector2(0, 1),
                    Direction.Right => new Vector2(+1, 0),
                };
                Position += dir * Speed * Globals.TotalSeconds;
            }
        }

        public void OnCollision(GameObject other)
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            AnimationManager.Update();
            Move();
        }

       
    }
}
