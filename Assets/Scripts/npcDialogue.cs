using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDialogue : MonoBehaviour
{

    public string[] dialogue;
    private int dialogueProgress = 0;
    // Update is called once per frame
    string getDialogue(){
        if(dialogueProgress < dialogue.Length)
        {
            dialogueProgress++;
            return dialogue[dialogueProgress - 1];
        }
        return dialogue[dialogueProgress];
    }
}
