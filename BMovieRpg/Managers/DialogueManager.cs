using ProjectRpg.Models.Characters;
using ProjectRpg.Models.Ui;
using System;
using System.Collections.Generic;
using System.Linq;
using static ProjectRpg.Structs.CustomType;

namespace ProjectRpg.Managers
{
    //TODO: Do more clean dialogue system 
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
            if (currentNpcDialogue.SoundEffect != null)
            {
                currentNpcDialogue.SoundEffect.Play();
            }
            //
        }

        public static void ManageDialogue(Npc npc)
        {
            
        }

        public static void Update()
        {
            
            if(!isFirstScreen && DialogueUI.IsActive)
            {
                Console.WriteLine(PlayerInputManager.isDialogueResponseMode.ToString() + PlayerInputManager.isDialogueSelected.ToString());
                PlayerInputManager.SetDialogueKey();

                if (PlayerInputManager.isDialogueResponseMode && PlayerInputManager.isDialogueSelected) 
                {
                    
                    Console.WriteLine(currentNpcDialogue.Text);
                    
                    Dialogue dialogueToDelete = dialoguesToShow[PlayerInputManager.dialogueKey];
                    dialoguesToShow.Remove(dialogueToDelete);
                    dialoguesToShow.RemoveAll(dialogue => dialogue.Id.StartsWith("N"));

                    Dialogue dialogueToAdd = allDialogues.FirstOrDefault(d => d.Id == dialogueToDelete.ResponseId);

                    // Add the dialogue to dialoguesToShow if it exists
                    if(dialogueToAdd.Text != null)
                    {
                        dialoguesToShow.Insert(0, dialogueToAdd);
                        currentNpcDialogue = dialogueToAdd;
                    }

                    if (currentNpcDialogue.SoundEffect != null)
                    {
                        currentNpcDialogue.SoundEffect.Play();
                    }

                    PlayerInputManager.isDialogueSelected = false;
                }
            }
        }
    }
}
