using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using ProjectRpg;

namespace ProjectRpg.Models.Ui
{
    public class DialogueUI: UIObject
    {
        protected Rectangle boxRect;

        public DialogueUI(Texture2D texture, Vector2 position, int width, int height) : base(texture, position, width, height)
        {
            boxRect = new Rectangle((int)this.position.X / 2 - width / 2, (int)this.position.Y / 2 - height /2 ,
                this.width, this.height );
        }

        public override void Draw()
        {
            Globals.SpriteBatch.Draw(Globals.PixelTexture, this.boxRect, new Color(244, 164, 96, 64));
            Globals.SpriteBatch.DrawString(Globals.Font, "anan", new Vector2(boxRect.X + 10, boxRect.Y + 10), Color.Black);

        }
    }
}
