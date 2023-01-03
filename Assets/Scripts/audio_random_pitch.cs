using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio_random_pitch : MonoBehaviour
{

    public float minPitch = -1;
    public float maxPitch = 1;
    private AudioSource aSource;
    // Start is called before the first frame update
    void Start()
    {
        aSource = gameObject.GetComponent<AudioSource>();
        aSource.pitch = Random.Range(minPitch, maxPitch);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
