using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Managers;
using ProjectRpg.Models.Physics;
using ProjectRpg.Structs;

namespace ProjectRpg.Models.Characters
{
    public class Character : DynGameObject, IAnimated, ICollidable
    {
        protected Data.PhyscData physcData;
        protected AnimationManager animationManager;
        
        public Character(Texture2D texture, string tag, Vector2 pos) : 
            base(texture, tag, pos)
        {
            physcData.Scale = 1f;
        }

        public AnimationManager AnimationManager { get { return animationManager; } protected set { animationManager = value; } }

        public float Scale { get { return physcData.Scale; } set { physcData.Scale = value; } }

        public virtual bool DidCollide(ICollidable callerObj, ICollidable otherObj)
        {
            bool didCollide = Collision.RectCollision(callerObj, otherObj);
            this.IsMoving = !didCollide;

            return didCollide;
        }

        public virtual void OnCollision()
        {
            this.Pos = LastPos;
        }

    }
}
