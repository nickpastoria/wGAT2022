using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WheelBehavior : MonoBehaviour
{
    public PlayerCarController player;
    public float rotationSpeed = 90f;
    public float maxDeg = 130f;
    public float damping = 0.5f;
    public float velocityToRotationScale = 1.0f;

    private RectTransform rectTransform;

    private float currentAngle;
    private float currentVelocity;

    void Start()
    {
        // Get UI element attatched to gameobject at start of game
        rectTransform = gameObject.GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        float targetAngle = Mathf.Clamp(player.getVelocity()*velocityToRotationScale, -maxDeg, maxDeg);
        currentAngle = Mathf.SmoothDampAngle(currentAngle, targetAngle, ref currentVelocity, damping, rotationSpeed);
        rectTransform.Rotate(Vector3.forward, currentAngle - rectTransform.rotation.eulerAngles.z);
    }
}
