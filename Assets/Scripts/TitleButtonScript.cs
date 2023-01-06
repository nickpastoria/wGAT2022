using UnityEngine;
using UnityEngine.UI;

public class TitleButtonScript : MonoBehaviour
{
    private Button button;

    // Scale of the button when it is fully inflated
    public Vector3 endScale = new Vector3(1.5f, 1.5f, 1.5f);

    // Duration of the animation
    public float duration = 0.5f;

    private void Start()
    {
        button = GetComponent<Button>();

        // Set the starting scale of the button
        Vector3 startScale = transform.localScale;

        // Scale the button up and down indefinitely
        LeanTween.scale(gameObject, endScale, duration)
            .setEase(LeanTweenType.easeInOutQuad)
            .setLoopPingPong();
    }
}
