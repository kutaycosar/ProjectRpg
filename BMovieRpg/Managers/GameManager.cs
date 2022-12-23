using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;

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
            _player = new Player(Globals.Content.Load<Texture2D>("player"), 0, "player", new Vector2(50,50), 200);
            _tree = new GameObject(Globals.Content.Load<Texture2D>("tree"), 0, "tree", new Vector2(200, 200));
            _bush = new GameObject(Globals.Content.Load<Texture2D>("bush"), 0, "bush", new Vector2(500, 500));

            GameObjectManager.AddGameObject(_tree, _bush);
        }

        public void Update()
        {
            PlayerInputManager.Update();
            _player.Update();
        }

        public void Draw()
        {
            _player.Draw();
            foreach (GameObject gameObject in GameObjectManager.GetGameObjects())
            {
                gameObject.Draw();
            }
        }
    }

}
