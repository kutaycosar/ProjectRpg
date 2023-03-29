using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace ProjectRpg
{
    public class Sprite
    {
        protected readonly Texture2D texture;
        
        public Sprite(Texture2D texture)
        {
            this.texture = texture;
        }
        public Texture2D GetTexture
        {
            get { return this.texture; }
        }
        
    }
}
