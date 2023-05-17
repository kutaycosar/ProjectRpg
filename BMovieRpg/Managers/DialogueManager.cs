using ProjectRpg.Models.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using static ProjectRpg.Structs.CustomType;

namespace ProjectRpg.Managers
{
    public static class DialogueManager
    {
        private static DialogueUI _dialogueUI;

        public static Dialogue currentPlayerDialogue;
        public static Dialogue currentNpcDialogue;

        static bool isFirstScreen = true;

        public static List<Dialogue> dialoguesToShow = new();

        public static DialogueUI DialogueUI { get { return _dialogueUI; } set { _dialogueUI = value; } }

        public static void SetFirstScreen(List<Dialogue> dialogues)
        {
            dialoguesToShow = dialogues.Where(d => d.Id == "N-A-1" || (d.Id.StartsWith("P-") && d.Id.EndsWith("1"))).ToList();
            currentNpcDialogue = dialogues.FirstOrDefault(d => d.Id == "N-A-1");
            isFirstScreen = false;
        }

        public static void SelectResponse() 
        { 

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

        public static void Update()
        {

        }
    }
}
