using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectRpg.Models.Characters
{
    public class Npc : Character
    {
        public Npc(Texture2D texture, float radius, string tag, Vector2 position, Vector2 hitPosBox) : base(texture, radius, tag, position, hitPosBox)
        {
        }
    }
}
