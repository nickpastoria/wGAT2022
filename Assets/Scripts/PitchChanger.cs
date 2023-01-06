using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PitchChanger : MonoBehaviour
{
    // The minimum and maximum values for the pitch
    public float minPitch = 0.5f;
    public float maxPitch = 1.5f;

    // The duration for which the pitch should be changed
    public float duration = 10f;

    // The AudioSource whose pitch will be changed
    public AudioSource audioSource;

    // A timer to track the elapsed time
    private float timer = 0f;

    // The original pitch of the audio source
    private float originalPitch;

    // The speed at which the pitch should change
    public float pitchChangeSpeed = 1f;

    // Tracks whether currently changing pitch or not
    private bool isChanging = false;

    public void TriggerPitchChange()
    {
        isChanging = true;
        timer = 0f;
    }

    void Start()
    {
        // Store the original pitch of the audio source
        originalPitch = audioSource.pitch;
    }

    void Update()
    {
        if( !isChanging ) return;
        // Increment the timer
        timer += Time.deltaTime;

        // If the timer has exceeded the duration
        if (timer > duration)
        {
            // Reset the timer
            timer = 0f;

            // Reset the pitch of the audio source
            audioSource.pitch = originalPitch;
            isChanging = false;
        }
        else
        {
            // Calculate the pitch change as a sinusoidal wave
            float pitchChange = Mathf.Sin(timer * pitchChangeSpeed);

            // Set the pitch of the audio source based on the pitch change
            audioSource.pitch = Mathf.Lerp(minPitch, maxPitch, pitchChange);
        }
    }
}
