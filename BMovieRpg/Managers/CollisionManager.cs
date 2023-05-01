using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ProjectRpg.Models.Characters;
using System.Linq;

namespace ProjectRpg.Managers
{
    public class InteractionManager
    {
        public static void HandleInteractions(GameObject callerObj)
        {
            foreach(GameObject gObj in GameObjectManager.GetGameObjects())
            {
                if(gObj != callerObj)//belki ikisi de ayni obje olur boyle cast yap
                {
                    if(gObj is ICollidable)
                    {
                        HandleCollision(callerObj as ICollidable, gObj as ICollidable);
                    }
                }
            }
        }

        public static void HandleCollision(ICollidable callerObj, ICollidable collidableObj)
        {
            float distance = Vector2.Distance(callerObj.Position, collidableObj.HitBoxPos);

            float combinedRadius = callerObj.Radius + collidableObj.Radius;

            if(callerObj.DidCollide(distance, combinedRadius))
            {
                callerObj.OnCollision();
            }
        }
        
    }
}
