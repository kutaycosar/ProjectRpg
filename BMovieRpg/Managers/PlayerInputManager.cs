using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ProjectRpg.Managers;

namespace ProjectRpg
{
    public static partial class PlayerInputManager
    {
        private static Direction _direction;
        public static int dialogueKey = -1;
        public static bool isDialogueSelected = false;
        public static bool _isFPressed;
        public static bool _escPressed;


        public static KeyboardState preKeyState;
        public static KeyboardState curKeyState;

        public static bool isDialogueMode = false;
        public static bool isDialogueResponseMode = false;
        public static Direction Direction
        {
            get { return _direction; }
        }

        public static bool WasKeyPressed(Keys key)
        {
            // checks if a specific key is currently being pressed and was not pressed in the previous frame.
            return curKeyState.IsKeyDown(key) && !preKeyState.IsKeyDown(key);  
        }

        public static void SetDialogueKey()
        {
            if (WasKeyPressed(Keys.D1))
                dialogueKey = 1;
            else if (WasKeyPressed(Keys.D2))
                dialogueKey = 2;
            else if (WasKeyPressed(Keys.D3))
                dialogueKey = 3;
            else if (WasKeyPressed(Keys.D4))
                dialogueKey = 4;

            if (dialogueKey != -1 && isDialogueResponseMode) isDialogueSelected = true;
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