using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ProjectRpg
{
    public class GameObject : Sprite
    {
        private string _tag;
        private Vector2 _position;

        public GameObject(Texture2D texture, float rotation, string tag, Vector2 position) : base(texture, rotation)
        {
            _tag = tag;
            _position = position;
        }

        public string Tag
        {
            get { return _tag; }
        }
        public Vector2 Position
        {
            get { return _position; }
            set { _position = value; }
        }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(_texture, Position, null, Color.White, Rotation, _origin, 1, SpriteEffects.None, 1);
        }
    }
}
