using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDamage : MonoBehaviour
{
    private GameManager gm;
    private void Start() {
        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy") gm.takeDamage();
    }
}
