using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class debugEffect : Effects
{
    public string logText = "LogText";
    // Start is called before the first frame update
    public override void RunEffect()
    {
        Debug.Log(logText + ": debugEffect.cs");
    }
}
