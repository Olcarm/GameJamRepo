using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileSpawn : MonoBehaviour
{
    public Transform spawnPos;
    public GameObject enemyProj;


    void Start()
    {
        StartCoroutine(FireProjectile(enemyProj));
    }

    IEnumerator FireProjectile(GameObject projName)
    {
        while (true)
        {
            Instantiate(projName, spawnPos.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(0.6f);
        }


    }

    void Update()
    {
        
    }
}
