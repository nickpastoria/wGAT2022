using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionTrigger : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player")
            {
                Debug.Log("Player has entered trigger");
                // Player has entered the trigger volume
                // Do something here, such as displaying a message or triggering an event
            }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player")
            {
                Debug.Log("Player has left trigger");
                // Player has entered the trigger volume
                // Do something here, such as displaying a message or triggering an event
            }
    }
}
