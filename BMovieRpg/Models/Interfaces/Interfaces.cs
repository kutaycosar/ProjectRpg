using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextureAtlas;

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
        void OnCollision(GameObject other);
    }

    public interface IAnimated
    {
        public AnimationManager AnimationManager { get; set; }
    }
}
