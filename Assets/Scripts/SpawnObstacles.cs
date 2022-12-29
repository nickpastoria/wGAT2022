using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameManager gameManger;

    public float spawnDistance = 100;

    private float timeBetween = 3; 
    public Transform [] allItems;
    private int whichItem = 0;
    private int xPos;
    private int xPos2;

    public int percentDouble;
    public int percentNone;
    private int x;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnTimer());
        timeBetween = 1.0f / (gameManger.songBPM / 60.0f);
    }

    // Update is called once per frame
    void Update()
    {
        timeBetween = 1.0f / (gameManger.songBPM / 60.0f);
    }

    IEnumerator spawnTimer(){
        yield return new WaitForSeconds(timeBetween);

        //chooses which item in allitems
        //augment to choose between spawning 1 or 2 cars
        //whichItem = Random.Range(0,4);

        if(spawnRatio() == 2){
            makeObstacle();
            makeObstacle(xPos);
        }
        else if(spawnRatio() == 1){
            makeObstacle();
        }

        StartCoroutine(spawnTimer());
    }




    void makeObstacle(){
        //this chooses the lane item spawns in
        xPos = Random.Range(-1, 2) * 3;

        //chooses which item is going to be spawned
        //where its going to be spawned (55 is outside camera range)
        //use default rotation
        Instantiate(allItems[whichItem], new Vector3(xPos, 0.05f, spawnDistance), allItems[whichItem].rotation);
    }

    //for making 2 obstacles
    void makeObstacle(int excludedLane){
        xPos2 = Random.Range(-1, 2) * 3;
        while(excludedLane == xPos2){
            xPos2 = Random.Range(-1, 2) * 3;
        }
        Instantiate(allItems[whichItem], new Vector3(xPos2, 0.05f, spawnDistance), allItems[whichItem].rotation);
    }

    //use the ratio var to figure out if we spawn 2 obstacles or not
    int spawnRatio(){
        //gets random num 0-100
        x = Random.Range(0, 101);

        //checks if we spawn min or max obstacles
        if(x < percentNone){ //guaranteed range for 0 spawns
            return 0;
        }
        else if(x <= percentDouble){
            return 2;
        }
        return 1;
    }
}
