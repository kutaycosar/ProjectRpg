using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectRpg.Models.Characters
{
    public class Npc : Character, IHasName
    {
        protected string _name;
        public Npc(Texture2D texture, float radius, string tag, Vector2 position, Vector2 hitPosBox, int speed,
            string name) : base(texture, radius, tag, position, hitPosBox, speed)
        {
            _name = name;
        }

        public string Name { get { return _name; } set { _name = value; } }
    }
}
