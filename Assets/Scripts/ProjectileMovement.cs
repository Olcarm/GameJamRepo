using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMovement : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] public float projSpeed;
    public float damage = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * projSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.x > 12f)
        {
            Destroy(this.gameObject);
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
        {
            other.GetComponent<Enemy1>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
