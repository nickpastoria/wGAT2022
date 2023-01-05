using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_TriggerWhale : Effects
{
    public Animator whaleAnimator;
    public AudioSource whaleAudio;

    private void Start() 
    {
        whaleAudio = whaleAnimator.GetComponent<AudioSource>();    
    } 
    public override void RunEffect()
    {
        whaleAudio.Play();
        whaleAnimator.SetTrigger("playWhaleAnim");
    }
}
