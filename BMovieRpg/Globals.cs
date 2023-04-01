using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;

using Dialogue = ProjectRpg.Structs.CustomType.Dialogue;

namespace ProjectRpg
{
    public static class Globals
    {
        public static float TotalSeconds { get; set; }
        public static ContentManager Content { get; set; }
        public static SpriteBatch SpriteBatch { get; set; }
        public static (int Width, int Height) ScreenSize { get; set; }
        public static Texture2D PixelTexture { get; set; }
        public static SpriteFont Font { get; set; }
        public static Point Bounds { get; set; }

        public static void Update(GameTime gt)
        {
            TotalSeconds = (float)gt.ElapsedGameTime.TotalSeconds;
        }
    }
}
