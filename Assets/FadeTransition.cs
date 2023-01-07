using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeTransition : MonoBehaviour
{
// Start is called before the first frame update
    private Animator animator;

    void Awake()
    {
        animator = gameObject.GetComponent<Animator>();
    
    }
    public void LevelTransition()
    {
        animator.SetTrigger("FadeOut");
    }
        
}
