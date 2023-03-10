using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using ProjectRpg.Models.Obstacles;

namespace ProjectRpg
{
    public class GameManager
    {
        private readonly Player _player;
        private readonly Texture2D _playerDown;
        private readonly Texture2D _playerUp;
        private readonly Texture2D _playerLeft;
        private readonly Texture2D _playerRight;
        private readonly Tree _tree;
        private readonly Bush _bush;
        
        public GameManager()//TODO: Buradaki yuklemeleri game1.cs de content.load da yukklenecek sekilde ayarla
        {
            _playerDown = Globals.Content.Load<Texture2D>("playerDown");
            _playerUp = Globals.Content.Load<Texture2D>("playerUp");
            _playerLeft = Globals.Content.Load<Texture2D>("playerLeft");
            _playerRight = Globals.Content.Load<Texture2D>("playerRight");


            //_player = new Player(Globals.Content.Load<Texture2D>("player"), 0, "player", new Vector2(50, 50), 200);
            _player = new Player(Globals.Content.Load<Texture2D>("player"), "player", new Vector2(50, 50));


            _player.AnimationManager.SetAnimation(0, new AnimatedSprite(_playerUp, 1, 4));
            _player.AnimationManager.SetAnimation(1, new AnimatedSprite(_playerLeft, 1, 4));
            _player.AnimationManager.SetAnimation(2, new AnimatedSprite(_playerDown, 1, 4));
            _player.AnimationManager.SetAnimation(3, new AnimatedSprite(_playerRight, 1, 4));

            _tree = new Tree(Globals.Content.Load<Texture2D>("tree"), "tree", new Vector2(600, 600));
            _bush = new Bush(Globals.Content.Load<Texture2D>("bush"), "bush", new Vector2(300, 300));

            GameObjectManager.AddGameObject(_tree, _bush);
        }

        public void Update()
        {
            PlayerInputManager.Update();
            _player.Update();
            Debug.WriteLine(Globals.TotalSeconds);
            Debug.Write("hitposx: " + _player.HitPosBox.X);
            Debug.Write("hitposy: " + _player.HitPosBox.Y);
        }
        
        public void Draw()
        {
            
            _player.AnimationManager.CurrentAnim.Draw(Globals.SpriteBatch, _player.Position);

            foreach (GameObject gameObject in GameObjectManager.GetGameObjects())
            {
                gameObject.Draw();
            }
        }
    }

}
