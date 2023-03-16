using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Models.Obstacles;
using ProjectRpg.Models.Characters;
using ProjectRpg.Models.Characters.Monsters;

namespace ProjectRpg
{
    public class GameManager
    {
        private Player _player;

        private Monster _snake;
        

        private Tree _tree;
        private Bush _bush;
        
        public GameManager()//TODO: Buradaki yuklemeleri ayri classlarda ypailacak sekilde ayarla yada method
        {
            initPlayer();
            initObjects();
            initEnemies();
        }

        public void Update(GameTime gameTime)
        {

            PlayerInputManager.Update();
            _player.Update();
            _snake.Update();

            Globals.Update(gameTime);

        }
        
        public void Draw()
        {
            
            _player.AnimationManager.CurrentAnim.Draw(Globals.SpriteBatch, _player.Position);

            foreach (GameObject gameObject in GameObjectManager.GetGameObjects())
            {
                gameObject.Draw();
            }
        }

        public void initPlayer()
        {
            _player = new Player(Globals.Content.Load<Texture2D>("player"), "player", new Vector2(50, 50));

            _player.AnimationManager.SetAnimation(0, new AnimatedSprite(Globals.Content.Load<Texture2D>("playerUp"), 1, 4));
            _player.AnimationManager.SetAnimation(1, new AnimatedSprite(Globals.Content.Load<Texture2D>("playerLeft"), 1, 4));
            _player.AnimationManager.SetAnimation(2, new AnimatedSprite(Globals.Content.Load<Texture2D>("playerDown"), 1, 4));
            _player.AnimationManager.SetAnimation(3, new AnimatedSprite(Globals.Content.Load<Texture2D>("playerRight"), 1, 4));
        }

        public void initObjects()
        {
            _tree = new Tree(Globals.Content.Load<Texture2D>("tree"), "tree", new Vector2(600, 600));
            _bush = new Bush(Globals.Content.Load<Texture2D>("bush"), "bush", new Vector2(300, 300));

            GameObjectManager.AddGameObject(_tree, _bush);
        }

        public void initEnemies()
        {
            //_snake = new Monster(Globals.Content.Load<Texture2D>("snakeEnemy"), "snake", new Vector2(400, 400));
            _snake = new Snake(Globals.Content.Load<Texture2D>("snakeEnemy"), "snake", new Vector2(400, 400));

            GameObjectManager.AddGameObject(_snake);
        }

    }

}
