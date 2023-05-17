using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjectRpg
{
    public static partial class PlayerInputManager
    {
        private static Direction _direction;
        public static bool _isFPressed;
        public static bool _escPressed;

        public static KeyboardState preKeyState;
        public static KeyboardState curKeyState;

        public static bool isDialogueMode = false;
        
        public static Direction Direction
        {
            get { return _direction; }
        }

        public static bool WasKeyPressed(Keys key)
        {
            return curKeyState.IsKeyDown(key) && !preKeyState.IsKeyDown(key);
        }

        public static void Update()
        {
            preKeyState = curKeyState;
            curKeyState = Keyboard.GetState();

            _direction = Direction.None;
            if (curKeyState.IsKeyDown(Keys.W)) _direction = Direction.Top;
            if (curKeyState.IsKeyDown(Keys.S)) _direction = Direction.Bottom;
            if (curKeyState.IsKeyDown(Keys.A)) _direction = Direction.Left;
            if (curKeyState.IsKeyDown(Keys.D)) _direction = Direction.Right;

            _isFPressed = curKeyState.IsKeyDown(Keys.F);
        }
    }

}