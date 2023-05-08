using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectRpg.Models.Characters.Monsters
{
    public class Snake : Monster
    {
        public Snake(Texture2D texture, string tag, Vector2 pos) : base(texture, tag, pos)
        {
            Speed = 200;
            LastPos = Pos;

            //Radius = 56;
            //HitBoxPos = new Vector2(Pos.X + 29, Pos.Y + 31);
        }
    }
}
