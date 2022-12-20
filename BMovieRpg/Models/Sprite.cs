using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ProjectRpg
{
    public class Sprite
    {
        protected readonly Texture2D _texture;
        protected readonly Vector2 _origin;
        private Vector2 _position;
        private int _speed;
        private float _rotation;

        public Sprite(Texture2D texture, Vector2 position)
        {
            _texture = texture;
            _position = position;
            _speed = 300;
            _origin = new(texture.Width / 2, texture.Height / 2);
        }

        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public int Speed
        {
            get { return _speed; }
            set { _speed = value; }
        }

        public float Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(_texture, Position, null, Color.White, Rotation, _origin, 1, SpriteEffects.None, 1);
        }
    }
}
