using Microsoft.Xna.Framework;

namespace ProjectRpg
{
    public interface IMovable
    {
        bool IsMoving { get; set; }
        int Speed { get; set; }

        public void Move();
    }

    public interface ICollidable
    {
        Vector2 LastPosition { get;}
        void OnCollision();
    }

    public interface IAnimated 
    {
        public AnimationManager AnimationManager { get; set; }
    }
}
