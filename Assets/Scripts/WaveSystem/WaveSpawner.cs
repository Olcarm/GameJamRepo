using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;

    private Wave currentWave;

    [SerializeField]
    private Transform[] spawnpoints;

    private float timeBtwnSpawns;
    private int i = 0;

    private bool stopSpawning = false;

    private void Awake()
    {
        currentWave = waves[i];

        timeBtwnSpawns = currentWave.TimeBeforeThisWave;

    }
    private void Update()
    {
        if (stopSpawning)
        {
            return;
        }
        if(Time.time >= timeBtwnSpawns)
        {
            StartCoroutine(SpawnWave());
            IncWave();

            timeBtwnSpawns = Time.time + currentWave.TimeBeforeThisWave;
        }


    }

    IEnumerator SpawnWave()
    {
        
        for(int i = 0; i < currentWave.NumbertToSpawn; i++ )
        {
            int num = Random.Range(0, currentWave.EnemiesInWave.Length);

            int num2 = Random.Range(0, spawnpoints.Length);

            Instantiate(currentWave.EnemiesInWave[num], spawnpoints[num2].position, spawnpoints[num2].rotation);
            yield return new WaitForSeconds(1);

        }
    }


    private void IncWave()
    {

        if(i+1 < waves.Length)
        {
            i++;
            currentWave = waves[i];
        }
        else
        {
            stopSpawning = true;
        }

    }


}
