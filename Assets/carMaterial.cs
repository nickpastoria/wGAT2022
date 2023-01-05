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
    [SerializeField]
    private GameObject brakeLightParticlePrefab;

    // Start is called before the first frame update
    void Start()
    {
        // Pick a random int 1 thru 6 For the 6 brakelight textures 
        int materialID = Random.Range(1, 7);
        Material carMat;
        Vector3 offsetPosition;

        switch (materialID)
        {
            case 1:
                carMat = carmat1;
                offsetPosition = new Vector3(-0.4f, 0.3f, -1.973f);
                break;
            case 2:
                carMat = carmat2;
                offsetPosition = new Vector3(-0.424f, 0.23f, -2.107f);
                break;
            case 3:
                carMat = carmat3;
                offsetPosition = new Vector3(-0.4f, 0.3f, -1.973f);
                break;
            case 4:
                carMat = carmat4;
                offsetPosition = new Vector3(-.459f, .281f, -2.107f);
                break;
            case 5:
                carMat = carmat5;
                offsetPosition = new Vector3(-.399f, .22f, -2.107f);
                break;
            case 6:
                carMat = carmat6;
                offsetPosition = new Vector3(-.42f, .28f, -2.107f);
                break;
            default:
                carMat = carmat1;
                offsetPosition = new Vector3(-0.4f, 0.3f, -1.973f);
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
        GameObject leftBrake = Instantiate(brakeLightParticlePrefab, this.transform);
        leftBrake.transform.localPosition = offsetPosition;
        GameObject rightBrake = Instantiate(brakeLightParticlePrefab, this.transform);
        offsetPosition.x *= -1;
        rightBrake.transform.localPosition = offsetPosition;
    }


}
