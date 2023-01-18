using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjectRpg
{
    public static partial class PlayerInputManager
    {
        private static Direction _direction;

        public static Direction Direction
        {
            get { return _direction; }
        }

        public static void Update()
        {
            KeyboardState keyboardState = Keyboard.GetState();

            _direction = Direction.None;
            if (keyboardState.IsKeyDown(Keys.W)) _direction = Direction.Top;
            if (keyboardState.IsKeyDown(Keys.S)) _direction = Direction.Bottom;
            if (keyboardState.IsKeyDown(Keys.A)) _direction = Direction.Left;
            if (keyboardState.IsKeyDown(Keys.D)) _direction = Direction.Right;

        }
    }

}