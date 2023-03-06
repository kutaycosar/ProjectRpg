using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using ProjectRpg.Managers;


namespace ProjectRpg.Models.Characters
{
    public sealed class Player : Character, IAnimated, IMovable, ICollidable
    {

        public Player(Texture2D texture, string tag, Vector2 position) : 
            base(texture, 0, tag, position, Vector2.Zero)
        {
            _isMoving = true;
            _speed = 200;
            _radius = 56;
            AnimationManager = new AnimationManager(new AnimatedSprite[4]);
            _lastPosition = position;
            _hitPosBox = new Vector2(Position.X + 29, Position.Y + 31);
            
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
                if(_isMoving == true)
                {
                    _lastPosition = Position;
                    Position += dir * Speed * Globals.TotalSeconds;
                }
                
            }
        }

        public override void OnCollision()
        {
            _isMoving = CollisionManager.DidCollide(this);
            if (!_isMoving) this.Position = LastPosition;  
        } 
        

        public override void Update()
        {
            OnCollision();


            AnimationManager.Update();
            HitPosBox = new Vector2(Position.X + 29, Position.Y + 31);

            Move();
        }

       
    }
}
