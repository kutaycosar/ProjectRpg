using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace ProjectRpg.Models.Characters
{
    public class Character : GameObject, IAnimated, IMovable, ICollidable
    {
        protected int _speed;
        protected bool _isMoving;
        protected Vector2 _lastPosition;
        public Character(Texture2D texture, float radius, string tag, Vector2 position, Vector2 hitPosBox,
            int speed) : 
            base(texture, radius, tag, position, hitPosBox)
        {
            _speed = speed;
            _isMoving = true;
            _lastPosition = Position;

        }

        public int Speed { get { return _speed; } set { _speed = value; } }

        public bool IsMoving { get { return IsMoving; } set { _isMoving = value; } }

        public Vector2 LastPosition { get { return _lastPosition; } }

        public AnimationManager AnimationManager { get; set; }

        public virtual void Move()
        {
            throw new System.NotImplementedException();
        }

        public virtual void OnCollision()
        {
            throw new System.NotImplementedException();
        }

        public virtual void Update()
        {
            throw new System.NotImplementedException();
        }
    }
   
}
