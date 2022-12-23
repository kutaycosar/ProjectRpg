using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextureAtlas;

namespace ProjectRpg.Managers
{
    public class AnimationManager
    {
        private AnimatedSprite _currentAnim;
        private AnimatedSprite[] _animations;

        public AnimationManager(AnimatedSprite[] animations)
        {
            _animations = animations;
        }

        public AnimatedSprite Speed { get { return _currentAnim; } set { _currentAnim = value; } }

        public void Update(GameObject gameObject)
        {

        }

        //public AnimatedSprite CurrentAnim()
        //{
        //    get{ return _currentAnim; }
        //}
    }
}
