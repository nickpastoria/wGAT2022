using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buildingMovement : MonoBehaviour
{
    public float parralax = 0.75f;
    private GameManager gm;

    private float speed;

    void Start() {
        GameObject gmOBJ = GameObject.FindGameObjectWithTag("GameManager");
        gm = gmOBJ.GetComponent<GameManager>();
        speed = gm.roadSpeed * parralax;
    }

    void Update()
    {
        speed = gm.roadSpeed * parralax;
        gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0, speed);
    }

    //when this object hits the back wall, destroy this object instance
    void OnTriggerEnter(Collider other){
        if(other.gameObject.tag == "lethal"){
            gameObject.GetComponent<Rigidbody>().transform.localPosition = Vector3.zero;
        }
    }
}
