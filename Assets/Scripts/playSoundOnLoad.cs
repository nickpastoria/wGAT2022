using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSoundOnLoad : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource aSource;
    void Start()
    {
        aSource = gameObject.GetComponent<AudioSource>();
        aSource.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
