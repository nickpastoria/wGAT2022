using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
public GameObject target; // The GameObject to look at
    void Update()
    {
        // Rotate the camera to look at the target GameObject
        transform.LookAt(target.transform);
    }
}
