using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPlayAudio : MonoBehaviour
{
    private AudioSource aSource;
    private void Start() 
    {
        aSource = gameObject.GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    public void PlayAudio()
    {
        aSource.Play();
    }
}
