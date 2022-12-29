using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScenery : MonoBehaviour
{
    public GameObject[] spawnPoints;
    private void OnValidate() {
        spawnPoints = GameObject.FindGameObjectsWithTag("ScenerySpawn");
    }
}
