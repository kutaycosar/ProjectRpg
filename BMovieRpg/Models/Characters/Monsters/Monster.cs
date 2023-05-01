using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Managers;

namespace ProjectRpg.Models.Characters
{
    public class Monster : Character
    {
        public Monster(Texture2D texture, string tag, Vector2 position)
            : base(texture, tag, position)
        {
        }

        public override void Move()
        {

        }

        public override void Update()
        {
            OnCollision();
            HitBoxPos = new Vector2(Position.X + 29, Position.Y + 31);
            Move();
        }

        public override void OnCollision()
        {
            //IsMoving = CollisionManager.DidCollide(this);
            //if (!IsMoving) Position = LastPos;
        }
    }
}
