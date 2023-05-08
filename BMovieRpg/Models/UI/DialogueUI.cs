using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ProjectRpg.Managers;
using ProjectRpg.Models.Characters;
using System.Collections.Generic;
using static ProjectRpg.Structs.CustomType; //staticle istegimiz memberi cagiririz bunu kullan


namespace ProjectRpg.Models.Ui
{
    public class DialogueUI: UIObject // Her objeye bir dialogue box yukleme, bir dialogue box olsun o objelerin konusma listesini alsin ekrana versin. sonra silinsin
    {
        protected Rectangle boxRect;
        //dialogue manager 

        public DialogueUI(Texture2D texture, Vector2 pos, int width, int height) : base(texture, pos, width, height)
        {
            boxRect = new Rectangle((int)this.Pos.X / 2 - width / 2, (int)this.Pos.Y / 2 - height /2 ,
            this.sizeData.Width, this.sizeData.Height);
        }

        //public override void Update()
        //{
        //    if (PlayerInputManager._isFPressed && PlayerInputManager.WasKeyPressed(Keys.F))
        //    {
        //        this.IsActive = this.IsActive ? false : true;
        //    }
        //}

        public override void Draw()
        {
            if (!isActive)
            {
                return;
            }
            Globals.SpriteBatch.Draw(Globals.PixelTexture, this.boxRect, new Color(244, 164, 96, 64));

            int offSetY = 10; // Offset for vertical Posing of each dialogue

            foreach (Dialogue dialogue in DialogueManager.dialoguesToShow)
            {
                Globals.SpriteBatch.DrawString(Globals.Font, dialogue.Text,
                    new Vector2(boxRect.X + 10, boxRect.Y + offSetY), Color.Black);

                offSetY += 20; // Increase the offset for the next dialogue
            }

            
        }

    }
}
