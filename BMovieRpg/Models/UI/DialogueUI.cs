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

        public DialogueUI(Texture2D texture, Vector2 position, int width, int height) : base(texture, position, width, height)
        {
            boxRect = new Rectangle((int)this.position.X / 2 - width / 2, (int)this.position.Y / 2 - height /2 ,
            this.sizeData.Width, this.sizeData.Height);
        }

        public override void Update()
        {
            if (PlayerInputManager._isFPressed && PlayerInputManager.WasKeyPressed(Keys.F))
            {
                this.IsActive = this.IsActive ? false : true;
            }
        }

        public override void Draw()
        {
            Globals.SpriteBatch.Draw(Globals.PixelTexture, this.boxRect, new Color(244, 164, 96, 64));
            Globals.SpriteBatch.DrawString(Globals.Font, $"is f pressed : {PlayerInputManager._isFPressed} " + $"was f pressed : {PlayerInputManager._isFPressed}", new Vector2(boxRect.X + 10, boxRect.Y + 10), Color.Black);

    
        }

    }
}
