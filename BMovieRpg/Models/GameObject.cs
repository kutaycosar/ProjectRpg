using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Structs;


namespace ProjectRpg
{
    
    public class GameObject : Sprite, ISObj//TODO: not every game object is collidable so think about making new class for collidable objects(obstacles?)
    {
        protected Data.PosData posData;
        protected string tag;
        

        public GameObject(Texture2D texture, string tag, Vector2 position) : base(texture)
        {
            this.tag = tag;
            this.posData.Pos = position;
        }

        public string Tag { get; set; }
        public Vector2 Position { get { return posData.Pos; } protected set { posData.Pos = value; } }
        public Vector2 CurrentPos { get { return posData.CurrentPos; } protected set { posData.CurrentPos = value; } }
        public Vector2 LastPos { get { return posData.LastPos; } protected set { posData.LastPos = value; } }

        public virtual void Draw()
        {
            Globals.SpriteBatch.Draw(this.texture, Position,Color.White);
        }

    }
}
