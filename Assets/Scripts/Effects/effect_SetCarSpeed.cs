using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_SetCarSpeed : Effects
{
    public float newRoadSpeed;

    public float timeToNewSpeed;
    private float current = 0f;
    private float currentVelocity = 0f;
    private bool isDampening = false;

    public override void RunEffect()
    {
        isDampening = true;
    }
    
    private void Update()
    {
        if(!isDampening) return;
        current = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().roadSpeed;
        GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>().roadSpeed = Mathf.SmoothDamp(current, newRoadSpeed, ref currentVelocity, timeToNewSpeed);
        if(current == newRoadSpeed) isDampening = false;
    }
    
}
