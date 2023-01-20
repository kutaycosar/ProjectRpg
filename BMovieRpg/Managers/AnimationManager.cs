using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg
{
    public class AnimationManager
    {
        private AnimatedSprite _currentAnim;
        private AnimatedSprite[] _animations;
        private float _animationSpeed = 0.1f;
        private float _elapsedTime;

        public AnimationManager(AnimatedSprite[] animations)
        {
            _animations = animations;
        }

        public AnimatedSprite CurrentAnim { get { return _currentAnim; } set { _currentAnim = value; } }
        public void SetAnimation(int index, AnimatedSprite animatedSprite)
        {
            _animations[index] = animatedSprite;
        }

        public void Update()
        {
            _elapsedTime += Globals.TotalSeconds;

            if (PlayerInputManager.Direction != Direction.None)
            {
                _currentAnim = _animations[(int)PlayerInputManager.Direction];


            }
            else
            {
                _currentAnim = _animations[0];
            }
            
            if(_animationSpeed < _elapsedTime)
            {
                _currentAnim.Update();
                _elapsedTime = 0f;
            }
            
        }

        //public AnimatedSprite CurrentAnim()
        //{
        //    get{ return _currentAnim; }
        //}
    }
}
