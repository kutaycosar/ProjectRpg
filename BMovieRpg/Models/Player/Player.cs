using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using ProjectRpg.Managers;

namespace ProjectRpg
{
    public class Player : GameObject, IAnimated, IMovable, ICollidable
    {
        protected int _speed;
        protected bool _isMoving;
        protected Vector2 _lastPosition;
        public AnimationManager AnimationManager { get; set; }

        public Player(Texture2D texture, string tag, Vector2 position) : 
            base(texture, 0, tag, position, Vector2.Zero)
        {
            _isMoving = true;
            _speed = 200;
            _radius = 56;
            AnimationManager = new AnimationManager(new AnimatedSprite[4]);
            _lastPosition = position;
            _hitPosBox = new Vector2(Position.X + 29, Position.Y + 31);
            
        }

        public int Speed {get { return _speed; }set { _speed = value; }}

        public bool IsMoving { get { return IsMoving; } set { _isMoving = value; } }

        public Vector2 LastPosition {get { return _lastPosition; }}
        

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

        public void OnCollision()
        {
            _isMoving = CollisionManager.DidCollide(this);
            if (!_isMoving) this.Position = LastPosition;  
        } 
        

        public void Update()
        {
            OnCollision();


            AnimationManager.Update();
            HitPosBox = new Vector2(Position.X + 29, Position.Y + 31);

            Move();
        }

       
    }
}
