using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace ProjectRpg.Models.Monsters
{
    public class Monster : GameObject, IMovable
    {
        protected int _speed;
        protected bool _isMoving;
        protected Direction _direction;
        public Monster(Texture2D texture, float rotation, string tag, Vector2 position, int speed) : base(texture, rotation, tag, position, Vector2.Zero)
        {
            _speed = speed;
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public bool IsMoving { get { return _isMoving; } set { _isMoving = value; } }

        public Direction Direction { get { return _direction; } }

        public void SetDirection(Direction direction)
        {
            _direction = direction;
        }

        public void Move()
        {

        }

        public void Update()
        {

        }
    }
}
