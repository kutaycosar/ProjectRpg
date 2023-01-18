using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Diagnostics;

namespace ProjectRpg
{
    public class GameManager
    {
        private readonly Player _player;
        private readonly Texture2D _playerDown;
        private readonly Texture2D _playerUp;
        private readonly Texture2D _playerLeft;
        private readonly Texture2D _playerRight;
        private readonly GameObject _tree;
        private readonly GameObject _bush;
        public GameManager()
        {
            _playerDown = Globals.Content.Load<Texture2D>("playerDown");
            _playerUp = Globals.Content.Load<Texture2D>("playerUp");
            _playerLeft = Globals.Content.Load<Texture2D>("playerLeft");
            _playerRight = Globals.Content.Load<Texture2D>("playerRight");


            _player = new Player(Globals.Content.Load<Texture2D>("player"), 0, "player", new Vector2(50,50), 200);

            _player.AnimationManager.SetAnimation(0, new AnimatedSprite(_playerUp, 1, 4));
            _player.AnimationManager.SetAnimation(1, new AnimatedSprite(_playerLeft, 1, 4));
            _player.AnimationManager.SetAnimation(2, new AnimatedSprite(_playerDown, 1, 4));
            _player.AnimationManager.SetAnimation(3, new AnimatedSprite(_playerRight, 1, 4));

            _tree = new GameObject(Globals.Content.Load<Texture2D>("tree"), 0, "tree", new Vector2(200, 200));
            _bush = new GameObject(Globals.Content.Load<Texture2D>("bush"), 0, "bush", new Vector2(500, 500));

            GameObjectManager.AddGameObject(_tree, _bush);
        }

        public void Update()
        {
            PlayerInputManager.Update();
            _player.AnimationManager.Update();
            _player.AnimationManager.CurrentAnim.Update();
            _player.Update();
        }

        public void Draw()
        {
            
            _player.AnimationManager.CurrentAnim.Draw(Globals.SpriteBatch, _player.Position);
            Debug.WriteLine("current frame" + _player.AnimationManager.CurrentAnim.currentFrame);
            Debug.WriteLine("current animation" + _player.AnimationManager.CurrentAnim.currentFrame);

            foreach (GameObject gameObject in GameObjectManager.GetGameObjects())
            {
                gameObject.Draw();
            }
        }
    }

}
