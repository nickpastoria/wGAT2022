using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect_setSpawnRatio : Effects
{

    public string description = "";
    public SpawnObstacles obstacleSpawner;
    [SerializeField, Range(0, 100)] private int _percentSingle;
    [SerializeField, Range(0, 100)] private int _percentDouble;

    [SerializeField, Range(0, 100)] private int _percentNone;

    private void OnValidate() 
    {
        _percentNone = 100 - (_percentSingle + _percentDouble);
        if( _percentNone >= 0 ) return ;
        Debug.LogWarning("effect_setSpawnRatio, Single(" + _percentSingle + "), Double(" + _percentDouble + ") are greater than 100%!");    
    }

    public override void RunEffect()
    {
        obstacleSpawner.percentNone = _percentNone;
        obstacleSpawner.percentDouble = _percentDouble;
        Debug.Log("Car spawn changed to None:(" + _percentNone + "), Single:(" + _percentSingle + "), Double:(" + _percentDouble + ")");
    }
}
