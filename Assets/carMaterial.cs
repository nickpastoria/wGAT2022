using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carMaterial : MonoBehaviour
{
    [SerializeField]
    private Material carmat1;
    [SerializeField]
    private Material carmat2;
    [SerializeField]
    private Material carmat3;
    [SerializeField]
    private Material carmat4;
    [SerializeField]
    private Material carmat5;
    [SerializeField]
    private Material carmat6;

    // Start is called before the first frame update
    void Start()
    {
        // Pick a random int 1 thru 6 For the 6 brakelight textures 
        int materialID = Random.Range(1, 7);
        Material carMat;

        switch (materialID)
        {
            case 1:
                carMat = carmat1;
                break;
            case 2:
                carMat = carmat2;
                break;
            case 3:
                carMat = carmat3;
                break;
            case 4:
                carMat = carmat4;
                break;
            case 5:
                carMat = carmat5;
                break;
            case 6:
                carMat = carmat6;
                break;
            default:
                carMat = carmat1;
                Debug.Log("Error in carmat script switch statement.  Random material ID invalid.");
                break;
        }

        // Make 33% of the cars white, the rest a random color
        /*
        Color randomColor = Color.white;
        float whiteProbability = 0.33f;
        float rand = Random.Range(0f, 1f);
        if (rand < whiteProbability)
        {
            randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
        }

        carMat.SetColor("_primary_color", randomColor);
        */
        GetComponent<Renderer>().material = carMat;
    }


}
