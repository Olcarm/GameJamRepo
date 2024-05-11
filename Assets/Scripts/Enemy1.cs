using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float health, maxHealth = 10f;


    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

}
