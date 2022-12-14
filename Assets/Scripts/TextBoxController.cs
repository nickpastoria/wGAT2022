using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextBoxController : MonoBehaviour
{
    //Handles the interaction of the Text Box Structure
    public TMP_Text NameDisplay;
    public TMP_Text BodyText;
    void Start() 
    {
        gameObject.SetActive(false);
    }

    public void DisplayDialogue(string name,string dialogue)
    {
        // Takes in a valid dialogue string
        // If the window is not active activate it
        // Update Text if window is already active
        gameObject.SetActive(true);
        NameDisplay.text = name;
        BodyText.text = dialogue;
    }

    public void HideWindow()
    {
        // If the window is open close it
        // If the window is closed don't do anything
        gameObject.SetActive(false);
    }
}
