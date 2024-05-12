using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave1 : WaveSpawnerSystem
{


    public float wave1spawntime = 20f;
    public float wave2spawntime = 2f;




    public enum levelSelector{wave1,wave2,wave3};
    public levelSelector mylevel;
    


    void Start()
    {
        mylevel = levelSelector.wave1;
    }


    void FixedUpdate()
    {
    if(GameObject.FindGameObjectsWithTag("Enemy") == null){

        spawnEnemies(1,2);


    }
    }
    

}













