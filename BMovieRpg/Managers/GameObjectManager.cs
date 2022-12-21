using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectRpg
{
    public static class GameObjectManager
    {
        private static List<GameObject> gameObjects = new List<GameObject>();

        public static void AddGameObject(params GameObject[] objects)
        {
            gameObjects.AddRange(objects);
        }

        public static List<GameObject> GetGameObjects()
        {
            return gameObjects;
        }
    }
}
