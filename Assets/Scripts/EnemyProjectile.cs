using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] public float projSpeed;
    public float damage = 2f;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = -transform.right * projSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.x > -12f)
        {
            Destroy(this.gameObject);
        }

        RotateProjectile();

    }
    void RotateProjectile()
    {

        transform.Rotate(new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5)) * 100f * Time.deltaTime, Space.Self);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerScript>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
