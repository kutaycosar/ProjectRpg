using ProjectRpg.Models;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg
{
    public class GameManager
    {
        private readonly Player _player;
        public GameManager()
        {
            _player = new(Globals.Content.Load<Texture2D>("player"), new(200, 200));
        }

        public void Update()
        {
            //InputManager.Update();
            _player.Update();
            //ProjectileManager.Update();
        }

        public void Draw()
        {
            //ProjectileManager.Draw();
            _player.Draw();
        }
    }

}
