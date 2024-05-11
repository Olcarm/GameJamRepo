using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{
    public GameObject proj1;
    public Transform spawnPos;
    
    
    void Start()
    {
        StartCoroutine(FireProjectile(proj1));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator FireProjectile(GameObject projName)
    {
        while (true)
        {
            Instantiate(projName, spawnPos.transform.position, spawnPos.transform.rotation);
            yield return new WaitForSeconds(0.3f);
        }
        

    }
}
