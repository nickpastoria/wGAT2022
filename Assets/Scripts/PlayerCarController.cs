using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] Lanes;
    public int startingLane = 1;
    [SerializeField]
    private int currentLane;

    //Things Needed For Smooth Damp
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    void Start() {
        currentLane = startingLane;
        transform.position = Lanes[startingLane].GetComponent<Transform>().position;
    }

    void Update() {
        InputHandler();
        LerpPosition();
    }

    void InputHandler() {
        if(Input.GetAxisRaw("Horizontal") > 0.1f && Input.GetButtonDown("Horizontal")) currentLane++;
        if(Input.GetAxisRaw("Horizontal") < -0.1f && Input.GetButtonDown("Horizontal")) currentLane--;
        currentLane = Mathf.Clamp(currentLane, 0, Lanes.GetLength(0) - 1);
    }

    void LerpPosition()
    {
            // Use Mathf.Lerp to interpolate between the start and end positions
        transform.position = Vector3.SmoothDamp(transform.position, Lanes[currentLane].GetComponent<Transform>().position, ref velocity, smoothTime);
    }
}
