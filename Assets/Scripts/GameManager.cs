using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public AudioSource gameSong;
    public float songBPM = 110.0f;
    public bool godMode = false;
    [SerializeField]
    private int health = 3;
    private float songCompletionPercent = 0;

    public void Update()
    {
        songCompletionPercent = gameSong.time / gameSong.clip.length;
    }

    public void takeDamage() 
    {
        if( godMode ) return ;
        health--;
        if( health > 0 ) return ;

        Debug.Log("Game Over!");
    }
}
