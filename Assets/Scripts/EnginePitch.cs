using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class EnginePitch : MonoBehaviour
{
    public AnimationCurve curve;
    public float enginePitch;
    public float engineVolume;
    private GameManager gm;
    private AudioSource engine;

    private void Start() {
        engine = gameObject.GetComponent<AudioSource>();
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    private void Update() {
        engine.pitch = curve.Evaluate(Mathf.Abs(gm.roadSpeed));
    }
}
