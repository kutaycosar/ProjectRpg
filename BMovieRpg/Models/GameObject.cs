using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ProjectRpg.Structs;
using System;
using System.Xml.Linq;

namespace ProjectRpg
{
    
    public class GameObject : Sprite, ISObj//TODO: not every game object is collidable so think about making new class for collidable objects(obstacles?)
    {
        protected PosData pos;
        protected string tag;
        

        public GameObject(Texture2D texture, string tag, Vector2 position) : base(texture)
        {
            this.tag = tag;
            this.pos.Pos = position;
        }

        public string Tag { get; set; }
        public Vector2 Position { get { return pos.Pos; } protected set { pos.Pos = value; } }
        public Vector2 CurrentPos { get { return pos.CurrentPos; } protected set { pos.CurrentPos = value; } }
        public Vector2 LastPos { get { return pos.LastPos; } protected set { pos.LastPos = value; } }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(this.texture, Position,Color.White);
        }

    }
}
