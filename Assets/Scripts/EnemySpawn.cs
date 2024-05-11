using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public float spawnRate;
    public Transform spawnPos;
    public GameObject enemyType;
    void Start()
    {
        StartCoroutine(SpawnEnemies(enemyType));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator SpawnEnemies(GameObject enemy)
    {
        while (true)
        {
            Instantiate(enemy, spawnPos.transform.position, spawnPos.transform.rotation);

            yield return new WaitForSeconds(1f);
        }
    }
}
