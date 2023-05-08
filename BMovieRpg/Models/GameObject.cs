using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Structs;


namespace ProjectRpg
{
    
    public class GameObject : Sprite, ISObj//TODO: not every game object is collidable so think about making new class for collidable objects(obstacles?)
    {
        protected string tag;
        protected Data.PosData posData;
        protected Data.SizeData offSetData;

        public GameObject(Texture2D texture, string tag, Vector2 pos) : base(texture)
        {
            this.tag = tag;
            this.posData.Pos = pos;
            this.offSetData.Width = 0;
            this.offSetData.Height = 0;
        }

        public string Tag { get; set; }
        public Vector2 Pos { get { return posData.Pos; } protected set { posData.Pos = value; } }
        public Vector2 CurrentPos { get { return posData.CurrentPos; } protected set { posData.CurrentPos = value; } }
        public Vector2 LastPos { get { return posData.LastPos; } protected set { posData.LastPos = value; } }

        public int OffSetX { get { return offSetData.Width; } }
        public int OffSetY { get { return offSetData.Height; } }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(this.texture, Pos,Color.White);
        }

    }
}
