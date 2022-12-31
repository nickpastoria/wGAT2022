using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalVolume : MonoBehaviour
{
    private float _globalVolume = 0;
    private void Awake() 
    {
        DontDestroyOnLoad(gameObject);    
    }

    private void Start() 
    {
        setGlobalVolume(0.0f);
    }

    public float getGlobalVolume()
    {
        return _globalVolume;
    }

    public float setGlobalVolume(float newVolume)
    {
        _globalVolume = Mathf.Clamp(newVolume, 0, 1);
        if(newVolume > 1 || newVolume < 0) Debug.LogWarning("Warning: global volume is attempting to be set out of range!");
        AudioListener.volume = _globalVolume;
        return _globalVolume;
    }
}
