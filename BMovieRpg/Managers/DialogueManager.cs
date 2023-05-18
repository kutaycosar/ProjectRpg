using ProjectRpg.Models.Characters;
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
        public static List<Dialogue> allDialogues = new();

        public static DialogueUI DialogueUI { get { return _dialogueUI; } set { _dialogueUI = value; } }

        public static void SetFirstScreen(Npc npc) 
        {
            allDialogues = npc.Dialogues;
            dialoguesToShow = npc.Dialogues.Where(d => d.Id == "N-A-1" || (d.Id.StartsWith("P-") && d.Id.EndsWith("1"))).ToList();
            currentNpcDialogue = npc.Dialogues.FirstOrDefault(d => d.Id == "N-A-1");
            isFirstScreen = false;
            PlayerInputManager.isDialogueResponseMode = true;
        }


        public static void ManageDialogue(Npc npc)
        {
            
        }

        public static void Update()
        {
            if(!isFirstScreen && DialogueUI.IsActive)
            {
                Console.WriteLine(PlayerInputManager.isDialogueSelected.ToString());
                PlayerInputManager.SetDialogueKey();

                if (PlayerInputManager.isDialogueSelected && PlayerInputManager.isDialogueResponseMode) 
                {
                    Dialogue dialogueToDelete = dialoguesToShow[PlayerInputManager.dialogueKey];
                    dialoguesToShow.Remove(dialogueToDelete);
                    dialoguesToShow.RemoveAll(dialogue => dialogue.Id.StartsWith("N"));

                    Dialogue dialogueToAdd = allDialogues.FirstOrDefault(d => d.Id == dialogueToDelete.ResponseId);

                    // Add the dialogue to dialoguesToShow if it exists
                    
                    dialoguesToShow.Insert(0,dialogueToAdd);
                    currentNpcDialogue = dialogueToAdd;
                    


                    PlayerInputManager.isDialogueSelected = false;
                    PlayerInputManager.isDialogueResponseMode = false;

                }
            }
        }
    }
}
