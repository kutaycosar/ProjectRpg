
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Structs;

namespace ProjectRpg
{
    public class Sprite
    {
        protected readonly Texture2D texture;
        protected Data.SizeData sizeData;
        
        public Sprite(Texture2D texture)
        {
            this.texture = texture;
            sizeData.Width = texture?.Width ?? 0; //TODO: nullsa yapmasini engelliyor daha iy ibir yol bul
            sizeData.Height = texture?.Height ?? 0;
        }
        public Texture2D Texture
        {
            get { return this.texture; }
        }
        
        public int Width { get { return this.sizeData.Width; } }
        public int Height { get { return this.sizeData.Height; } }
       
    }
}
