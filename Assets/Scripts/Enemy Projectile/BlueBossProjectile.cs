using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueBossProjectile : MonoBehaviour
{
    public GameObject bullet1;
    public GameObject bullet2;
    public Transform bulSpawnPos;

    public int bulSpawnCount;
    [SerializeField]
    private float startAngle, endAngle, currentAngle;


    void Start()
    {
        StartCoroutine(Fire());
        StartCoroutine(SineBullet());
    }

    
    void Update()
    {
        
    }

    IEnumerator SineBullet()
    {
        while(true)
        {
            Instantiate(bullet2, bulSpawnPos.transform.position, Quaternion.identity);
            yield return new WaitForSeconds(1f);
        }
        
    }
    IEnumerator Fire()
    {
        while (true)
        {
            float anglestep = (endAngle - startAngle) / bulSpawnCount;
            currentAngle = startAngle;
            for (int i = 0; i < bulSpawnCount + 1; i++)
            {
                Instantiate(bullet1, bulSpawnPos.transform.position, Quaternion.Euler(0, 0, currentAngle));
                currentAngle += anglestep;
            }
            yield return new WaitForSeconds(1f);
        
        }

    }

}
