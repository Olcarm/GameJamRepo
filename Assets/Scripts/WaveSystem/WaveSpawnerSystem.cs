using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawnerSystem : MonoBehaviour
{

    public GameObject[] Race1Enemies;
    public GameObject[] Race2Enemies;

    public GameObject SpawnPointsObject;
  


    public Vector3[] ConvertPoints(){
        int i = SpawnPointsObject.transform.childCount;
        Vector3[] Points = new Vector3[i];
        for(int j = 0;j!=i;j++){
            Points[j] = SpawnPointsObject.transform.GetChild(j).transform.position;
        }
        return Points;
    }


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
                
                if(Random.Range(0,2)==0){
                    EnemyPool[i] = Race1Enemies[Random.Range(0,Race1Enemies.Length)];
                }
                else{
                    EnemyPool[i] = Race2Enemies[Random.Range(0,Race2Enemies.Length)];
                }
                
            }
        }
        
        return EnemyPool;
    }



    public void spawnEnemies(int race,int size){

        Vector3[] spawnpoints = ConvertPoints();

        GameObject[] Enemies = CreateEnemyPool(race,size);
        
        for(int i = 0; i <= Enemies.Length-1 ; i++)
        {
            
            Instantiate(Enemies[i], spawnpoints[Random.Range(0,spawnpoints.Length-1)], Quaternion.identity);

        }

    }



 




}
