using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_TriggerWhale : Effects
{
    public Animator whaleAnimator; 
    public override void RunEffect()
    {
        whaleAnimator.SetTrigger("playWhaleAnim");
    }
}
