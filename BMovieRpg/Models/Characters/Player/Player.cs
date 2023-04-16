using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Managers;


namespace ProjectRpg.Models.Characters
{
    public sealed class Player : Person
    {
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
                if(IsMoving == true)
                {
                    LastPos = Position;
                    Position += dir * Speed * Globals.TotalSeconds;
                }
                
            }
        }

        public override void OnCollision()
        {
            IsMoving = CollisionManager.DidCollide(this);
            if (!IsMoving) this.Position = LastPos;  
        } 

        public void Interact()
        {

        }

        public override void Update()
        {
            OnCollision();

            AnimationManager.Update();
            HitBoxPos = new Vector2(Position.X + 29, Position.Y + 31);

            Move();
        }
    }
}
