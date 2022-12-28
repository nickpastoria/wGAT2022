using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_SetBPM : Effects
{
    public int newBPM;
    private GameManager gm;
    private void Start()
    {
        gm = gameObject.GetComponent<GameManager>();
    }
    public override void RunEffect()
    {
        gm.songBPM = newBPM;
    }
}
