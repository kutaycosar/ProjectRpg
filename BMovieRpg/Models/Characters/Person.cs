using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;


namespace ProjectRpg.Models.Characters
{
    public class Person : Character, IHasName
    {
        protected string name;
        public Person(string name, Texture2D texture, string tag, Vector2 position) : base(texture, tag, position)
        {
            this.name = name;
        }

        public string Name { get { return this.name; } set { this.name = value; } }
    }
}
