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

    private float currentAngle;
    private float currentVelocity;
    // Update is called once per frame
    void Update()
    {
        float targetAngle = Mathf.Clamp(player.getVelocity()*velocityToRotationScale, -maxDeg, maxDeg);
        currentAngle = Mathf.SmoothDampAngle(currentAngle, targetAngle, ref currentVelocity, damping, rotationSpeed);
        transform.Rotate(Vector3.forward, currentAngle - transform.rotation.eulerAngles.z);
    }
}
