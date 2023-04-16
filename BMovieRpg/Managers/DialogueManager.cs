using System;
using System.Collections.Generic;
using System.Linq;
using static ProjectRpg.Structs.CustomType;

namespace ProjectRpg.Managers
{
    public static class DialogueManager
    {
        static Dialogue currentPlayerDialogue;
        static Dialogue currentNpcDialogue;

        static bool isFirstScreen = true;

        static List<Dialogue> dialoguesToShow = new();

        public static void SetFirstScreen(List<Dialogue> dialogues)
        {
            dialoguesToShow = dialogues.Where(d => d.Id.EndsWith("1")).ToList();
            isFirstScreen = false;
            currentNpcDialogue = dialogues.FirstOrDefault(d => d.Id == "N-A-1");
        }

        public static void ManageDialogue()
        {

            //if (playerchoice key not end with -> or end" //yani sonunda end yoksa) diyelim ki P-C-1
            //{
            //   currentNpcDialogue = (playerChoice change P to N return N-P-1
            //}
            //dialoguesToShow.Add()

            //if(playerChoice key end with ->)
            //{
            //    currentNpcDialogue = (playerchoice change p to N and + 1) N-A-2-end
            //}

            //if(playerChoice key end with end)
            //{
            //    currentNpcDialogue = default
            //}
        }
       
    }
}
