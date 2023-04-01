using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Structs;
using System;

namespace ProjectRpg.Models.Ui
{
    public class UIObject : Sprite, IUI
    {
        protected Vector2 position;
        protected Data.SizeData sizeData;
        protected bool isActive;

        public UIObject(Texture2D texture, Vector2 position, int width, int height) : base(texture)
        {
            this.position = position;
            this.sizeData.Width = width;
            this.sizeData.Height = height;
            this.isActive = false;
        }

        public Vector2 Position { get { return this.position; } }
        public int Width { get { return this.sizeData.Width; } }
        public int Height { get { return this.sizeData.Height; } }

        public bool IsActive { get { return this.isActive; } set { isActive = value; } }

        public virtual void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
