using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groupParralaxSetting : MonoBehaviour
{
    // Start is called before the first frame update
    public float groupParralax = 0.90f;
    void Start()
    {
        buildingMovement[] scriptKiddies = gameObject.GetComponentsInChildren<buildingMovement>();
        foreach (buildingMovement child in scriptKiddies)
        {
            child.parralax = groupParralax;
        }
    }
}
