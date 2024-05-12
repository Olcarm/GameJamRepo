using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawnerSystem : MonoBehaviour
{

    public GameObject[] Race1Enemies;
    public GameObject[] Race2Enemies;

    private Vector3 SpawnPoint = new Vector3(0,0,6);





    private GameObject[] CreateEnemyPool(int race,int size){

        GameObject[] EnemyPool = new GameObject[size];
        
        for(int i = 0;i<=size-1;i++)
        {
           
            if(race == 1){
              EnemyPool[i] = Race1Enemies[Random.Range(0,Race1Enemies.Length)];
            }else if(race == 2){
                EnemyPool[i] = Race2Enemies[Random.Range(0,Race2Enemies.Length)];
            }
            else{
                
                if(Random.Range(0,1)==1){
                    Debug.Log(EnemyPool[i]);
                    EnemyPool[i] = Race1Enemies[Random.Range(0,size)];

                }
                else{
                    Debug.Log(EnemyPool[i]);
                    EnemyPool[i] = Race2Enemies[Random.Range(0,size)];
                }
                
            }
        }
        
        return EnemyPool;
    }



    public void spawnEnemies(int race,int size){

        GameObject[] Enemies = CreateEnemyPool(race,size);
        
        for(int i = 0; i <= Enemies.Length-1 ; i++)
        {
            Debug.Log(Enemies.Length);

            Instantiate(Enemies[i], SpawnPoint, Quaternion.identity);



        }



    }



    void Start()
    {
        
        spawnEnemies(0,5);
    }





}
