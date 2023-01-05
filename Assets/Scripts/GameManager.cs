using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [System.Serializable]
    public class Changes
    {
        public int _ActivationPercentage;
        [SerializeField] private Effects[] effects;
        public void Activate()
        {
            Debug.Log("Changes activated at " + _ActivationPercentage + "%");
            for(int i = 0; i < effects.Length; i++)
            {
                effects[i].RunEffect();
            }
        }
    }

    /*[System.Serializable]
    public class Effects
    {
        public enum SelectedFunction
        {
            debugLog,
            setCarSpeed,

        }
        public SelectedFunction selectedFunction;

        [SerializeField] private float var;
        public void runFunction()
        {
            switch(selectedFunction)
            {
                case SelectedFunction.debugLog:
                    Debug.Log("LOGGED");
                    break;

                case SelectedFunction.setCarSpeed:
                    Debug.Log("Setting Car Speed to " + var);
                    break;
                default:
                    Debug.LogError("Invalid Switch Function Selected! (Perhaps you forgot to add effect to functions)");
                    break;
            }
        }
    }*/

    public AudioSource gameSong;

    public float roadSpeed;
    public float songBPM = 110.0f;
    public bool godMode = false;
    [SerializeField]
    private int health = 3;
    private int songCompletionPercent = 0;
    private int lastCompletionPercent;
    public Changes[] changes;
    private int changesIterator = 0;

    [Header("End Scene")]
    public bool stopSpawn = false;
    MenuManager m;
    public float delayTime = 2f;

    public void Start() 
    {
        lastCompletionPercent = songCompletionPercent;
        stopSpawn = false;
        m = GameObject.FindGameObjectWithTag("MenuManager").GetComponent<MenuManager>();
    }

    public void Update()
    {
        songCompletionPercent = (int)(gameSong.time / gameSong.clip.length * 100.0f);

        //song over - end scene
        if(songCompletionPercent == 100){
            Invoke("m.NextScene()", delayTime);
        }

        if(changesIterator >= changes.Length) return ;
        if(songCompletionPercent >= changes[changesIterator]._ActivationPercentage)
        {
            changes[changesIterator].Activate();
            changesIterator++;
        }
        if(songCompletionPercent != lastCompletionPercent)
        {
            Debug.Log(songCompletionPercent + "%");
            lastCompletionPercent = songCompletionPercent;
        } 
        //case: song over -> stop obstacle spawning 
        if(songCompletionPercent == 98){
            stopSpawn = true;
        }
    }

    public void takeDamage() 
    {
        if( godMode ) return ;
        health--;
        if( health > 0 ) return ;

        Debug.Log("Game Over!");
    }

    void Restart(){
        Invoke("m.PlayGame()", delayTime);
    }
}
