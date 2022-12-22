using UnityEngine;

public class MovingObj : MonoBehaviour
{
    public float speed = -5.1f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, speed);
    }

    //when this object hits the back wall, destroy this object instance
    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "lethal"){
            Destroy (gameObject);
        }
    }
}
