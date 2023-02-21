using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace ProjectRpg.Managers
{
    public class CollisionManager
    {
        public static bool DidCollide(GameObject callerObject)
        {

            foreach (GameObject gObj in GameObjectManager.GetGameObjects())
            {
                float distance = Vector2.Distance(callerObject.Position, gObj.HitPosBox);

                float combinedRadius = callerObject.Radius + gObj.Radius;

                if (distance < combinedRadius)
                {
                    return false;
                    //callerObject.Position = _lastPosition;
                }
                
            }
            return true;
        }
    }
}
