using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueHighEnProjSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private GameObject projectile2;
    [SerializeField]
    private float fireRate;

    private int bulSpawnCount = 8;
    [SerializeField]
    private float startAngle = -90f, endAngle = 90f, currentAngle;

    void Start()
    {
        StartCoroutine(SpawnProjectiles());
        StartCoroutine(SineBullet());
    }

    IEnumerator SpawnProjectiles()
    {
        while (true)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1 / fireRate);
        }
        
    }
    IEnumerator SineBullet()
    {
        while (true)
        {
            Instantiate(projectile2, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1);
        }

    }
    void Update()
    {
        
    }
}
