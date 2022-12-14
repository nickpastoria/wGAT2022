using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcDialogue : MonoBehaviour
{
    //This script is a datastructure script and should be referenced for ui stuff

    public string characterName = "Temp";
    private int dialogueProgress = 0;
    [SerializeField]
    private string[] dialogue;
    
    // Update is called once per frame
    public string getDialogue(){
        if(dialogueProgress < dialogue.Length)
        {
            dialogueProgress++;
            
        }
        return dialogue[dialogueProgress - 1];
    }
}
