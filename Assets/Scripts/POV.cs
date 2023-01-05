using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POV : MonoBehaviour
{
    public AnimationCurve povCurve;
    private GameManager gm;
    private Camera camera;
    // Start is called before the first frame update
    void Start()
    {
        camera = gameObject.GetComponent<Camera>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        camera.fieldOfView = povCurve.Evaluate(Mathf.Abs(gm.roadSpeed));
    }
}
