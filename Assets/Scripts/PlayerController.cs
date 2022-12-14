using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float accelleration = 10.0f;
    public float maxSpeed = 10.0f;


    private Rigidbody rb;

    void Start(){
        rb = GetComponent<Rigidbody>();
        if(rb == null) {
            Debug.LogWarning("Playercontroller does not have a rigidbody attatched");
        }
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0, vertical) * accelleration;

        if(rb.velocity.magnitude < maxSpeed)
        {
            rb.AddForce(direction);
        }
    }
}