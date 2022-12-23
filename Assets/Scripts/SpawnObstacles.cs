using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameManager gameManger;
    private int timeBetween = 3; 
    public Transform [] allItems;
    private int whichItem = 0;
    private int xPos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnTimer());
        timeBetween = gameManger.songBPM / 60;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator spawnTimer(){
        yield return new WaitForSeconds(timeBetween);

        //chooses which item in allitems
        //augment to choose between spawning 1 or 2 cars
        //whichItem = Random.Range(0,4);

        //this chooses the lane item spawns in
        xPos = Random.Range(-1, 2) * 3;

        //chooses which item is going to be spawned
        //where its going to be spawned (55 is outside camera range)
        //use default rotation
        Instantiate(allItems[whichItem], new Vector3(xPos, 0.05f, 40), allItems[whichItem].rotation);
        StartCoroutine(spawnTimer());
    }
}
