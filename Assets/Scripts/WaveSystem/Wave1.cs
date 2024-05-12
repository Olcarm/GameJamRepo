using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1 : WaveSpawnerSystem
{


    public float wave1spawntime = 20f;
    public float wave2spawntime = 2f;


void Start()
{
    StartCoroutine(WaitAndSpawn(3.0f));
}


IEnumerator WaitAndSpawn(float waitTime)
{

    while(true){

    spawnEnemies(1,1);

    yield return new WaitForSeconds(waitTime);
    }
    

}










}
