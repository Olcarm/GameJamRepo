using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using Random = UnityEngine.Random;

public class WaveSpawner : MonoBehaviour
{
    public Wave[] waves;

    private Wave currentWave;

    [SerializeField]
    private Transform[] spawnpoints;

    private float timeBtwnSpawns;
    private int i = 0;

    private bool stopSpawning = false;
    public GameDifficulty difficulty;
    public float blueEnemyTotalCost = 0;
    public float redEnemyTotalCost = 0;
    private void Awake()
    {
        currentWave = waves[i];

        timeBtwnSpawns = currentWave.TimeBeforeThisWave;

        if(difficulty.CurrentEnemy == 0)
        {
            blueEnemyTotalCost = currentWave.EnemyTotalCost;
            SetDifficulty(0);
        }
        else if(difficulty.CurrentEnemy == 1)
        {
            SetDifficulty(1);
            redEnemyTotalCost = currentWave.EnemyTotalCost;
        }
    }
    private void Update()
    {
        
        if (stopSpawning)
        {
            return;
        }
        if(Time.time >= timeBtwnSpawns)
        {
            StartCoroutine(BlueSpawnWave());
            StartCoroutine(RedSpawnWave());
            IncWave();

            timeBtwnSpawns = Time.time + currentWave.TimeBeforeThisWave;
        }


    }

    IEnumerator BlueSpawnWave()
    {
        
        for(int i = 0; i < blueEnemyTotalCost; )
        {
            int num = Random.Range(0, currentWave.BlueEnemiesInWave.Length);

            int num2 = Random.Range(0, spawnpoints.Length);

            Instantiate(currentWave.BlueEnemiesInWave[num], spawnpoints[num2].position, spawnpoints[num2].rotation);
            i += currentWave.BlueEnemyCosts[num];
            
            yield return new WaitForSeconds(1);

        }
    }
    IEnumerator RedSpawnWave()
    {

        for (int i = 0; i < redEnemyTotalCost;)
        {
            int num = Random.Range(0, currentWave.RedEnemiesInWave.Length);

            int num2 = Random.Range(0, spawnpoints.Length);

            Instantiate(currentWave.RedEnemiesInWave[num], spawnpoints[num2].position, spawnpoints[num2].rotation);
            i += currentWave.RedEnemyCosts[num];

            yield return new WaitForSeconds(1);

        }
    }

    private void SetDifficulty(float currentEnemy)
    {
        if (currentEnemy == 0)
        {
            switch (difficulty.Blue)
            {
                case 0:
                    blueEnemyTotalCost = currentWave.TotalCost; break;
                case -1:
                    blueEnemyTotalCost += currentWave.TotalCost * 0.1f;
                    break;
                case -2:
                    blueEnemyTotalCost += currentWave.TotalCost * 0.15f;
                    break;
                case -3:
                    blueEnemyTotalCost += currentWave.TotalCost * 0.2f;
                    break;
                case -4:
                    blueEnemyTotalCost += currentWave.TotalCost * 0.25f;
                    break;

            }
            switch (difficulty.Red)
            {
                case 1:
                    redEnemyTotalCost += currentWave.TotalCost * 0.05f;
                    break;
                case 2:
                    redEnemyTotalCost += currentWave.TotalCost * 0.1f;
                    break;
                case 3:
                    redEnemyTotalCost += currentWave.TotalCost * 0.15f;
                    break;
                case 4:
                    redEnemyTotalCost += currentWave.TotalCost * 0.2f;
                    break;
            }
        }
        else if(currentEnemy == 1)
        {
            switch (difficulty.Red)
            {
                case 0:
                    redEnemyTotalCost = currentWave.TotalCost;
                    break;
                case -1:
                    redEnemyTotalCost += currentWave.TotalCost * 0.1f;
                    break;
                case -2:
                    redEnemyTotalCost += currentWave.TotalCost * 0.15f;
                    break;
                case -3:
                    redEnemyTotalCost += currentWave.TotalCost * 0.2f;
                    break;
                case -4:
                    redEnemyTotalCost += currentWave.TotalCost * 0.25f;
                    break;

            }
            switch (difficulty.Blue)
            {
                case 1:
                    blueEnemyTotalCost += currentWave.TotalCost * 0.05f;
                    break;
                case 2:
                    blueEnemyTotalCost += currentWave.TotalCost * 0.1f;
                    break;
                case 3:
                    blueEnemyTotalCost += currentWave.TotalCost * 0.15f;
                    break;
                case 4:
                    blueEnemyTotalCost += currentWave.TotalCost * 0.2f;
                    break;
            }
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
