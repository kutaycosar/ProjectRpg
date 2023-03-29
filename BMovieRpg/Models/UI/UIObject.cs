using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg.Models.Ui
{
    public class UIObject : Sprite, IUI
    {
        protected Vector2 position;
        protected int width;
        protected int height;
        protected bool isActive;

        public UIObject(Texture2D texture, Vector2 position, int width, int height) : base(texture)
        {
            this.position = position;
            this.width = width;
            this.height = height;
            this.isActive = false;
        }

        public Vector2 Position { get { return this.position; } }
        public int Width { get { return this.Width; } }
        public int Height { get { return this.Height; } }

        public bool IsActive { get; set; }

        public virtual void Draw()
        {
            throw new NotImplementedException();
        }
    }
}
