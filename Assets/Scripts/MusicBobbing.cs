using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicBobbing : MonoBehaviour
{
    public GameManager gm;
    public float amplitude;
    public float attitudeAdjustment;
    public float max;
    public float min;
    private float gameTime;
    const float radsToBPM = (2 * Mathf.PI / 60);

    void Update()
    {
        gameTime += Time.deltaTime;
        float bobAmount = Mathf.Clamp(getBobAmount() * amplitude, min, max);
        transform.position = transform.position + new Vector3(0, bobAmount, 0);
    }
    
    public float getBobAmount() 
    {
        return Mathf.Sin(gameTime * radsToBPM * gm.songBPM) + attitudeAdjustment;
    }
}
