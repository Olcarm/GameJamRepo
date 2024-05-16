using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] public float projSpeed;
    private float damage;
    public Player playerStats;
    void Start()
    {
        damage = playerStats.damage;
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * -projSpeed;
        
        Destroy(this.gameObject, 10);
    }
    private void Awake()
    {
        
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.GetComponent<BaseEnemy>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
