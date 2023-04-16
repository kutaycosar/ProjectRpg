using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Linq;

namespace ProjectRpg.Managers
{
    public class CollisionManager
    {
        public static bool DidCollide(ICollidable callerObject)
        {

            foreach (ICollidable collidable in GameObjectManager.GetGameObjects())
            {
                if (collidable != callerObject)
                {
                    float distance = Vector2.Distance(callerObject.Position, collidable.HitBoxPos);

                    float combinedRadius = callerObject.Radius + collidable.Radius;

                    if (distance < combinedRadius)
                    {
                        return false;
                    }
                }

            }
            return true;
        }

        public static void InteractionManager(GameObject callerObject)
        {
            foreach(GameObject gObj in GameObjectManager.GetGameObjects())
            {


            }
        }
    }
}
