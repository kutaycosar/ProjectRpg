using Microsoft.Xna.Framework;
using ProjectRpg.Structs;
using System.Collections.Generic;
using static ProjectRpg.Structs.CustomType;

namespace ProjectRpg
{
    public interface ISObj
    {
        string Tag { get;}
        Vector2 Position { get;}
        Vector2 CurrentPos { get; }
        Vector2 LastPos { get; }

        void Draw();
    }


    public interface IMovable
    {
        bool IsMoving { get; }
        int Speed { get;}
        Direction Direction { get; }
        void Move();
        void Update();
    }

    public interface ICollidable
    {
        Vector2 Position { get; }  
        float Radius { get; }
        Vector2 HitBoxPos { get; }
        bool DidCollide(float distance, float combinedRadius);
        void OnCollision();
    }

    public interface IAnimated 
    {
        public AnimationManager AnimationManager { get; }
    }

    public interface IHasName
    {
        public string Name { get; set; }
    }

    public interface IUI
    {
        Vector2 Position { get; }
        int Width { get; }
        int Height { get; }
        bool IsActive { get; set; }
        void Draw();
    }

    public interface IHasDialogue
    {
        List<Dialogue> Dialogues { get;}
    }

}
