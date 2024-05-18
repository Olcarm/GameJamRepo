using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerProjectiles : MonoBehaviour
{
    public GameObject proj1;
    public Transform spawnPos;
    public Player playerStats;
    private float attackRate;
    
    void Start()
    {
        attackRate = playerStats.attackRate;
        StartCoroutine(FireProjectile(proj1, attackRate));
        
    }

    IEnumerator FireProjectile(GameObject projName, float attackRate)
    {
        while (true)
        {
            AudioManager.Instance.PlaySFX("PlayerAttack");
            Instantiate(projName, spawnPos.transform.position, spawnPos.transform.rotation);
            
            yield return new WaitForSeconds(1/attackRate);
        }
    }

}

