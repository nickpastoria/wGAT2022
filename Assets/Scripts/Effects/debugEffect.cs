using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugEffect : Effects
{
    public string logText = "LogText";

    // Declare two public variables for the sliders, and use the Range attribute to specify the range of values that each slider can take
    [Range(0, 50)]
    public float slider1;

    [Range(50, 100)]
    public float slider2;

    private void OnValidate()
    {
        // Set the value of slider2 to be the difference between 100 and the value of slider1
        slider2 = 100 - slider1;
    }
    // Start is called before the first frame update
    public override void RunEffect()
    {
        Debug.Log(logText + ": debugEffect.cs");
    }
}
