using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyAnimController : MonoBehaviour
{
    public Animator anim;

    private void Start() {
        if(anim == null) anim = gameObject.GetComponentInChildren<Animator>();
    }

    public void kill()
    {
        anim.SetTrigger("playCarDeath");
    }
}
