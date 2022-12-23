using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RotationFX : MonoBehaviour
{
    public float rotationSpeed = 90f;
    public float maxDeg = 130f;
    public float damping = 0.5f;
    public float velocityToRotationScale = 1.0f;

    private float currentAngle;
    private float currentVelocity;

    // Update is called once per frame
    void Update()
    {
        float targetAngle = Mathf.Clamp(gameObject.GetComponent<PlayerCarController>().getVelocity()*velocityToRotationScale, -maxDeg, maxDeg);
        currentAngle = Mathf.SmoothDampAngle(currentAngle, targetAngle, ref currentVelocity, damping, rotationSpeed);
        transform.Rotate(Vector3.up, currentAngle - transform.rotation.eulerAngles.y);
    }
}
