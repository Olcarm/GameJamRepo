using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Enemy1 : MonoBehaviour
{
    public float health, maxHealth = 10f;
    public float speed;
    public float yRange;

    private Transform current;
    private Transform target;
    private float sinTime;

    void Start()
    {
        current = GameObject.FindGameObjectWithTag("Current").transform;
        target = GameObject.FindGameObjectWithTag("Target").transform;

        health = maxHealth;

        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(transform.position.y != target.position.y)
        {
            sinTime += Time.deltaTime * speed;
            sinTime = Mathf.Clamp(sinTime, 0 ,Mathf.PI);
            float t = evaluate(sinTime);
            transform.position = Vector3.Lerp(current.position, target.position, t);
        }
        swap();
        
        
    }
    public void swap()
    {
        if(transform.position != target.position)
        {
            return;
        }
        Transform t = current;
        current = target;
        target = t;
        sinTime = 0;
    }
    public void TakeDamage(float damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    public float evaluate(float x)
    {
        return 0.5f * Mathf.Sin(x - Mathf.PI / 2f) + 0.5f;
    }
}
