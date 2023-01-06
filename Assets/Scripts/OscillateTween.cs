using UnityEngine;

public class OscillateTween : MonoBehaviour
{
    public float oscillateDuration;
    public float oscillateAmount;
    public float frequency;
    public float delay;
    public float destroyDelay;
    public float scaleFactor;

    void Start()
    {
        // Oscillate the position and scale of the sprite upwards
        LeanTween.moveLocalY(gameObject, oscillateAmount + 350, oscillateDuration)
            .setEase(LeanTweenType.easeInOutSine)
            .setLoopCount(1)
            .setDelay(delay)
            .setOnComplete(() => {
                Destroy(gameObject, destroyDelay);
            })
            .setOnUpdate((float value) => {
                float scale = 1 + value * scaleFactor;
                transform.localScale = new Vector3(scale, scale, scale);
            });
    }
}
