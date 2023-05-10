using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using ProjectRpg.Models.Characters;
using ProjectRpg.Models.Physics;

namespace ProjectRpg.Managers
{
    public static class InteractionManager
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

                    if(callerObj is Player && gObj is Npc)
                    {
                        if (Collision.RectCollision(callerObj as ICollidable, gObj as ICollidable, 1.2f))
                        {
                            if (PlayerInputManager._isFPressed && PlayerInputManager.WasKeyPressed(Keys.F))
                            {
                                HandleDialogue(callerObj as Player, gObj as Npc);
                            }
                        }
                    }
                }
            }
        }

        public static void HandleCollision(ICollidable callerObj, ICollidable otherObj)
        {
            if (callerObj.DidCollide(callerObj, otherObj))
            {
                callerObj.OnCollision();
            }
        }

        public static void HandleDialogue(Player callerObj, Npc npcObj)
        {
            DialogueManager.DialogueUI.ToggleActive();
            DialogueManager.SetFirstScreen(npcObj.Dialogues);
        }
        
    }
}
