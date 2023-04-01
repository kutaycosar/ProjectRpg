using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ProjectRpg.Structs;
using System.Collections.Generic;

using static ProjectRpg.Structs.CustomType;

namespace ProjectRpg.Models.Characters
{
    public class Npc : Person, IDialogue
    {
        //when player press space when near to npc first in gameManager dialoguebox will have dialogueList in here, then dialogue pop up will be open
        // 
        List<Dialogue> dialogues = new();
        public Npc(string name, Texture2D texture, string tag, Vector2 position) : base(name, texture, tag, position)
        {

        }
        public List<Dialogue> Dialogues { get { return this.dialogues; } set { this.dialogues = value; } }
    }
}
