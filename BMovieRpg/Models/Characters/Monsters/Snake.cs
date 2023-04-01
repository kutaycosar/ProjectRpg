using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectRpg.Models.Characters.Monsters
{
    public class Snake : Monster
    {
        public Snake(Texture2D texture, string tag, Vector2 position) : base(texture, tag, position)
        {
            Speed = 200;
            LastPos = Position;

            Radius = 56;
            HitBoxPos = new Vector2(Position.X + 29, Position.Y + 31);
        }
    }
}
