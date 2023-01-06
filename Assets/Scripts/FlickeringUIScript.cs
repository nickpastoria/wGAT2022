using UnityEngine;
using UnityEngine.UI;

public class FlickeringUIScript : MonoBehaviour
{
    // Speed of the flicker
    public float frequency = 2.0f;

    // Image component of the UI element
    private Image image;

    void Start()
    {
        // Get the Image component attached to the GameObject
        image = GetComponent<Image>();
    }

    void Update()
    {
        // Calculate the intensity of the flicker using a sin wave
        float intensity = Mathf.Sin(Time.time * frequency) * 0.5f + 0.5f;

        // Set the alpha value of the color based on the intensity
        Color color = image.color;
        color.a = intensity;
        image.color = color;
    }
}

