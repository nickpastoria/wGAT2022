using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{

    public Camera cam;
    public Animator Vignette;
    public PitchChanger pc;
    private GameManager gm;
    private void Start() {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag != "Enemy") return ;
        gm.takeDamage();
        other.GetComponent<enemyAnimController>().kill();
        Camera.main.GetComponent<cameraShake>().TriggerShake(0.25f);
        if(pc != null) pc.TriggerPitchChange();
        if(Vignette != null) playVignette();
    }

    private void playVignette()
    {
        Vignette.SetTrigger("playDamageFlash");
    }
}
