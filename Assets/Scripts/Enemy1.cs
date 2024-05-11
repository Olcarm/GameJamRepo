using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1 : MonoBehaviour
{
    public float health, maxHealth = 10f;
    public float speed;
    public float yRange;
    void Start()
    {
        health = maxHealth;
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y >= yRange)
        {
            transform.Translate(Vector3.up * speed * -1 * Time.deltaTime);
        }
        else if (transform.position.y <= -yRange)
        {
            transform.Translate(Vector3.up * speed * 1 * Time.deltaTime);
        }

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
