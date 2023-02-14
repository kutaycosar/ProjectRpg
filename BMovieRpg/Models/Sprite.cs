using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace ProjectRpg
{
    public class Sprite
    {
        protected readonly Texture2D _texture;
        
        public Sprite(Texture2D texture)
        {
            _texture = texture;
        }
        public Texture2D GetTexture
        {
            get { return _texture; }
        }
        
    }
}
