using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace ProjectRpg
{
    public class GameObject : Sprite//TODO: not every game object is collidable so think about making new class for collidable objects(obstacles?)
    {
        private string _tag;
        private Vector2 _position;
        private float _radius; // TODO: Radius u center position u baz alarak dene

        public GameObject(Texture2D texture, float rotation, string tag, Vector2 position) : base(texture, rotation)
        {
            _tag = tag;
            _position = position;
            _radius = (this._texture.Width + this._texture.Height) / 4f;


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

        public float GetRadius
        {
            get { return _radius; }
        }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(_texture, Position, null, Color.White, Rotation, _origin, 1, SpriteEffects.None, 1);
        }
    }
}
