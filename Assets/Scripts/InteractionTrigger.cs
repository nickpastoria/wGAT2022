using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionTrigger : MonoBehaviour
{
    // Text that shows up when player enteres interaction box
    public GameObject uiInteractionText;
    public TextBoxController textBox;

    private npcDialogue dialogueQueue;

    private bool isInTrigger = false;

    void Start()
    {
        dialogueQueue = gameObject.GetComponent<npcDialogue>();
    }

    void Update()
    {
        updateTextBox();
    }

    private void updateTextBox() 
    {
        if(isInteractingtWithNPC())
        {
            textBox.DisplayDialogue(dialogueQueue.characterName, dialogueQueue.getDialogue());
            uiInteractionText.SetActive(false);
        }
    }

    private bool isInteractingtWithNPC() 
    {
        //returns true if player uses interact key within range of npc else false
        if(isInTrigger && Input.GetButtonDown("Interact"))
        {
            return true;
        } 
        return false;
    }

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
            {
                Debug.Log("Player has entered trigger");
                uiInteractionText.SetActive(true);
                isInTrigger = true;
                // Player has entered the trigger volume
                // Do something here, such as displaying a message or triggering an event
            }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player")
            {
                Debug.Log("Player has left trigger");
                uiInteractionText.SetActive(false);
                textBox.HideWindow(); 
                isInTrigger = false;
                // Player has entered the trigger volume
                // Do something here, such as displaying a message or triggering an event
            }
    }
}
