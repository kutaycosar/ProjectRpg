using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Managers;

namespace ProjectRpg.Models.Characters
{
    public class Monster : Character
    {
        public Monster(Texture2D texture, string tag, Vector2 pos)
            : base(texture, tag, pos)
        {
        }

        public override void Move()
        {

        }

        public override void Update()
        {
            OnCollision();
            Move();
        }

        public override void OnCollision()
        {
            //IsMoving = CollisionManager.DidCollide(this);
            //if (!IsMoving) Pos = LastPos;
        }
    }
}
