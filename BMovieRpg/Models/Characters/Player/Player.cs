using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Managers;
using ProjectRpg.Models.Physics;

namespace ProjectRpg.Models.Characters
{
    public sealed class Player : Person
    {
        public int Number { get; set; }
        public Player(string name, Texture2D texture, string tag, Vector2 pos) : 
            base(name,texture,tag, pos)
        {
            this.moveData.Speed = 200;
            this.animationManager = new AnimationManager(new AnimatedSprite[4]);
        }

        public override void Move() //TODO: bunu monsterlarin da kullanabilecegi sekilde ayarla
        {
            if (PlayerInputManager.Direction != Direction.None)
            {
                //Vector2 dir = Vector2.Normalize(PlayerInputManager.Direction);
                Vector2 dir = PlayerInputManager.Direction switch
                {
                    Direction.Top => new Vector2(0, -1),
                    Direction.Left => new Vector2(-1, 0),
                    Direction.Bottom => new Vector2(0, 1),
                    Direction.Right => new Vector2(+1, 0),
                };
                if (IsMoving)
                {
                    LastPos = Pos;
                    Pos += dir * Speed * Globals.TotalSeconds;
                }
            }
        }

        public override bool DidCollide(ICollidable callerObj, ICollidable otherObj)
        {
            return base.DidCollide(this, otherObj);
        }

        public override void OnCollision()
        {
            base.OnCollision();
        }

        public override void Update()
        {
            InteractionManager.HandleInteractions(this);

            if (!PlayerInputManager.isDialogueMode) {
                AnimationManager.Update();
                Move();
            }
            else
            {

            }
        }
    }
}
