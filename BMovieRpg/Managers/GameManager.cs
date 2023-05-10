using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Models.Obstacles;
using ProjectRpg.Models.Characters;
using ProjectRpg.Models.Characters.Monsters;
using ProjectRpg.Models.Ui;
using ProjectRpg.Models.Characters.Npcs;
using ProjectRpg.Managers;

namespace ProjectRpg
{
    public class GameManager
    {
        private Player _player;

        //private Npc _npc;
        private TestNpc _testNpc;
        private TestNpc _dialogueNpc;

        //private Monster _snake;

        private Tree _tree;
        private Bush _bush;

        private DialogueUI _dialogueUi;


        public GameManager()//TODO: Buradaki yuklemeleri ayri classlarda ypailacak sekilde ayarla yada method
        {
            InitUiElements();
            InitPlayer();
            InitNpc();
            InitObjects();
            InitEnemies();
        }

        public void Update(GameTime gameTime)
        {

            PlayerInputManager.Update();
            _player.Update();
            //_snake.Update();

            //_dialogueUi.Update();

            Globals.Update(gameTime);

        }
        
        public void Draw()
        {
            _player.AnimationManager.CurrentAnim.Draw(Globals.SpriteBatch, _player.Pos);
            

            foreach (GameObject gameObject in GameObjectManager.GetGameObjects())
            {
                gameObject.Draw();
            }

            if(_dialogueUi.IsActive) _dialogueUi.Draw();

        }

        public void InitUiElements()
        {
            _dialogueUi = new DialogueUI(null, new Vector2(Globals.ScreenSize.Width, Globals.ScreenSize.Height), 400, 200);
            DialogueManager.DialogueUI = _dialogueUi;
        }

        public void InitPlayer()
        {
            _player = new Player("kutay", Globals.Content.Load<Texture2D>("player"), "player", new Vector2(100, 100));

            _player.AnimationManager.SetAnimation(0, new AnimatedSprite(Globals.Content.Load<Texture2D>("playerUp"), 1, 4));
            _player.AnimationManager.SetAnimation(1, new AnimatedSprite(Globals.Content.Load<Texture2D>("playerLeft"), 1, 4));
            _player.AnimationManager.SetAnimation(2, new AnimatedSprite(Globals.Content.Load<Texture2D>("playerDown"), 1, 4));
            _player.AnimationManager.SetAnimation(3, new AnimatedSprite(Globals.Content.Load<Texture2D>("playerRight"), 1, 4));
        }

        public void InitNpc()
        {
            //_npc = new Npc("satici", Globals.Content.Load<Texture2D>("player"), "npc", new Vector2(800, 800));
            _dialogueNpc = new TestNpc("konusucu", Globals.Content.Load<Texture2D>("player"), "npc", new Vector2(100, 150));



            GameObjectManager.AddGameObject(/*_npc, */_dialogueNpc);
        }

        public void InitObjects()
        {
            _tree = new Tree(Globals.Content.Load<Texture2D>("tree"), "tree", new Vector2(600, 600));
            _bush = new Bush(Globals.Content.Load<Texture2D>("bush"), "bush", new Vector2(300, 300));

            

            GameObjectManager.AddGameObject(_tree, _bush);
        }

        public void InitEnemies()
        {
            //_snake = new Monster(Globals.Content.Load<Texture2D>("snakeEnemy"), "snake", new Vector2(400, 400));
            //_snake = new Snake(Globals.Content.Load<Texture2D>("snakeEnemy"), "snake", new Vector2(400, 400));

            //GameObjectManager.AddGameObject(_snake);
        }
    }
}
