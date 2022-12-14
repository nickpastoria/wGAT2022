using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractionTrigger : MonoBehaviour
{
    // Text that shows up when player enteres interaction box
    public GameObject uiInteractionText;

    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
            {
                Debug.Log("Player has entered trigger");
                uiInteractionText.SetActive(true);
                // Player has entered the trigger volume
                // Do something here, such as displaying a message or triggering an event
            }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player")
            {
                Debug.Log("Player has left trigger");
                uiInteractionText.SetActive(false);
                // Player has entered the trigger volume
                // Do something here, such as displaying a message or triggering an event
            }
    }
}
