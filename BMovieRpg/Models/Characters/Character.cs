using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Structs;

namespace ProjectRpg.Models.Characters
{
    public class Character : DynGameObject, IAnimated, ICollidable
    {
        protected Data.PhyscData physcData;
        protected AnimationManager animationManager;
        
        public Character(Texture2D texture, string tag, Vector2 position) : 
            base(texture, tag, position)
        {
        }

        public AnimationManager AnimationManager { get { return animationManager; } protected set { animationManager = value; } }

        public float Radius { get { return physcData.Radius; } protected set { physcData.Radius = value; } }
        public Vector2 HitBoxPos {get { return physcData.HitBoxPos; } protected set { physcData.HitBoxPos = value; } }

        public virtual void OnCollision()
        {
            throw new System.NotImplementedException();
        }

    }
}
