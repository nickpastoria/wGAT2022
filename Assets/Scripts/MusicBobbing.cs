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
    private float gameTime = 0;
    const float radsToBPM = (2 * Mathf.PI / 60);
    private float startingY;

    void Start() 
    {
        startingY = transform.position.y;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
        float bobAmount = Mathf.Clamp(getBobAmount() * amplitude  + attitudeAdjustment, min, max);
        transform.position = new Vector3(transform.position.x, startingY + bobAmount, transform.position.z);
    }
    
    public float getBobAmount() 
    {
        return Mathf.Sin(gameTime * radsToBPM * gm.songBPM);
    }
}
