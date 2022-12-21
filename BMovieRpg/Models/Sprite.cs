using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ProjectRpg
{
    public class Sprite
    {
        protected readonly Texture2D _texture;
        protected readonly Vector2 _origin;
        private float _rotation;
        public Sprite(Texture2D texture, float rotation)
        {
            _texture = texture;

            _rotation = rotation;   
            
            _origin = new(texture.Width / 2, texture.Height / 2);
        }

        public float Rotation
        {
            get { return _rotation; }
            set { _rotation = value; }
        }
    }
}
