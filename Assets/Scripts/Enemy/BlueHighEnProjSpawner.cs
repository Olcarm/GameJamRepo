using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueHighEnProjSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject projectile;
    [SerializeField]
    private float fireRate;

    void Start()
    {
        StartCoroutine(SpawnProjectiles());
    }

    IEnumerator SpawnProjectiles()
    {
        while (true)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1 / fireRate);
        }
        
    }
    
    void Update()
    {
        
    }
}
