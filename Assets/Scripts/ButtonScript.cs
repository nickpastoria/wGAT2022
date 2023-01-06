using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    private Button button;

    private void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SpinButton);
    }

    private void SpinButton()
    {
        LeanTween.rotateAround(gameObject, Vector3.up, 360, 1.15f).setLoopClamp();
    }
}

