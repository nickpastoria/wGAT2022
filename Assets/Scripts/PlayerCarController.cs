using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCarController : MonoBehaviour
{
        enum Direction 
    {
        Left,
        Right
    };
    // Start is called before the first frame update
    public GameObject[] Lanes;
    public int startingLane = 1;
    [SerializeField]
    private int currentLane;

    //Things Needed For Smooth Damp
    public float smoothTime = 0.3F;
    private Vector3 velocity = Vector3.zero;

    private Direction lastKeyPress; 



    void Start() {
        currentLane = startingLane;
        transform.position = Lanes[startingLane].GetComponent<Transform>().position;
    }

    void Update() {
        InputHandler();
        LerpPosition();
    }

    void InputHandler() {
        if(Input.GetAxisRaw("Horizontal") > 0.1f && Input.GetButtonDown("Horizontal"))
        {
            currentLane++;
            lastKeyPress = Direction.Right;
        } 
        if(Input.GetAxisRaw("Horizontal") < -0.1f && Input.GetButtonDown("Horizontal"))
        {
            currentLane--;
            lastKeyPress = Direction.Left;
        } 
        currentLane = Mathf.Clamp(currentLane, 0, Lanes.GetLength(0) - 1);
    }

    void LerpPosition()
    {
            // Use Mathf.Lerp to interpolate between the start and end positions
        transform.position = Vector3.SmoothDamp(transform.position, Lanes[currentLane].GetComponent<Transform>().position, ref velocity, smoothTime);
    }

    public float getVelocity(){
        // This will be an amalgamation of magnitude and direction inferred from two things.
        // The magnitude will come from the velocity magnitude and the direction will come from the last keypress
        float carDir = 0;
        float vel1D;

        if(lastKeyPress == Direction.Right) carDir = 1.0f;
        if(lastKeyPress == Direction.Left) carDir = -1.0f;
        vel1D = velocity.magnitude * carDir;
        return vel1D;        
    }
}
