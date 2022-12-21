using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;


namespace ProjectRpg
{
    public class Monster : GameObject, IMovable
    {
        private int _speed;
        private bool _isMoving;
        public Monster(Texture2D texture, float rotation, string tag, Vector2 position, int speed) : base(texture, rotation, tag, position)
        {
            _speed = speed;
        }

        public int Speed 
        { 
            get { return _speed; }
            set { _speed = value; }
        }

        public bool IsMoving { get { return _isMoving; } set { _isMoving = value; } }

        public void Move()
        {
            
        }

        public void Update()
        {

        }
    }
}
