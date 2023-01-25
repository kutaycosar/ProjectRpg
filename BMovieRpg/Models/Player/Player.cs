using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectRpg
{
    public class Player : GameObject,IAnimated, IMovable, ICollidable
    {
        private int _speed;
        private bool _isMoving;
        private Vector2 _lastPosition;
        public AnimationManager AnimationManager { get; set; }
        public Player(Texture2D texture, float rotation, string tag, Vector2 position, int speed) : base(texture, rotation, tag, position)
        {
            _isMoving = true;
            _speed = speed;
            AnimationManager = new AnimationManager(new AnimatedSprite[4]);
            _lastPosition = position;
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
                if(_isMoving == true)
                {
                    _lastPosition = Position;
                    Position += dir * Speed * Globals.TotalSeconds;
                }
                
            }
        }

        public void OnCollision(List<GameObject> gameObjects)
        {
            foreach (GameObject gObj in gameObjects) //TODO: distance i center positionu baz alarak yap
            {
                float distance = Vector2.Distance(new Vector2(Position.X - this.GetTexture.Width / 2, Position.Y - this.GetTexture.Height / 2), 
                    new Vector2(gObj.Position.X - gObj.GetTexture.Width / 2, gObj.Position.Y - GetTexture.Height));

                float combinedRadius = this.GetRadius + gObj.GetRadius;

                if (distance < combinedRadius)
                {
                    _isMoving = false;
                    Position = _lastPosition;
                }
                else
                {
                    _isMoving = true;
                }
            }
        }

        public void Update()
        {
            OnCollision(GameObjectManager.GetGameObjects());

            AnimationManager.Update();

            Move();
        }

       
    }
}
