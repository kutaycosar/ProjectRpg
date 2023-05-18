using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Structs;
using System;

namespace ProjectRpg.Models.Ui
{
    public class UIObject : Sprite, IUI
    {
        protected Vector2 pos;
        protected Data.SizeData sizeData;
        protected bool isActive;

        public UIObject(Texture2D texture, Vector2 pos, int width, int height) : base(texture)
        {
            this.pos = pos;
            this.sizeData.Width = width;
            this.sizeData.Height = height;
            this.isActive = false;
        }

        public Vector2 Pos { get { return this.pos; } }
        public virtual void Activate() { throw new NotImplementedException(); }
        public virtual void Deactivate() { throw new NotImplementedException(); }
        public bool IsActive { get { return this.isActive; }}

        public virtual void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
