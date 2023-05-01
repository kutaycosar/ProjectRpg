using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Managers;
using ProjectRpg.Models.Physics;

namespace ProjectRpg.Models.Characters
{
    public sealed class Player : Person
    {
        public int Number { get; set; }
        public Player(string name, Texture2D texture, string tag, Vector2 position) : 
            base(name,texture,tag, position)
        {
            this.moveData.Speed = 200;
            this.physcData.Radius = 56;
            this.physcData.HitBoxPos = new Vector2(Position.X + 29, Position.Y + 31);

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
                    LastPos = Position;
                    Position += dir * Speed * Globals.TotalSeconds;
                }

            }
        }

        public override bool DidCollide(float distance, float combinedRadius)
        {
            return base.DidCollide(distance, combinedRadius);
        }

        public override void OnCollision()
        {
            base.OnCollision();
        }

        public override void Update()
        {
            InteractionManager.HandleInteractions(this);

            AnimationManager.Update();
            HitBoxPos = new Vector2(Position.X + 29, Position.Y + 31);

            Move();
        }
    }
}
