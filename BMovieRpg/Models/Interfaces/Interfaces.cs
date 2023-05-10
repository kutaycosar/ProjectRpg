using Microsoft.Xna.Framework;
using ProjectRpg.Structs;
using System.Collections.Generic;
using static ProjectRpg.Structs.CustomType;

namespace ProjectRpg
{
    public interface ISObj
    {
        int OffSetX { get; }
        int OffSetY { get; }
        string Tag { get;}
        Vector2 Pos { get;}
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
        int Width { get; }
        int Height { get; }
        int OffSetX { get; }
        int OffSetY { get; }
        float Scale { get; }
        Vector2 Pos { get; }  
        bool DidCollide(ICollidable callerObj, ICollidable otherObj);
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
        Vector2 Pos { get; }
        int Width { get; }
        int Height { get; }
        bool IsActive { get; set; }

        void ToggleActive();

        void Draw();
    }

    public interface IHasDialogue
    {
        List<Dialogue> Dialogues { get;}
    }

}
