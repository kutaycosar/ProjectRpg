using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace ProjectRpg
{
    public class GameObject : Sprite//TODO: not every game object is collidable so think about making new class for collidable objects(obstacles?)
    {
        protected string _tag;
        protected Vector2 _position;
        protected float _radius;
        protected Vector2 _hitPosBox;

        public GameObject(Texture2D texture, float radius, string tag, Vector2 position, Vector2 hitPosBox) : base(texture)
        {
            _tag = tag;
            _position = position;
            _radius = radius;
            _hitPosBox = hitPosBox;
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

        public float Radius
        {
            get { return _radius; }
        }

        public Vector2 HitPosBox
        {
            get { return _hitPosBox; }
            set { _hitPosBox = value; }
        }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(_texture, Position,Color.White);
        }
    }
}
