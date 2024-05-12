using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    [SerializeField] public float projSpeed;
    public float damage = 2f;

    public void CheckDestroy()
    {
        if (gameObject.transform.position.x < -12f)
        {
            Destroy(this.gameObject);
        }
    }
    public void RotateProjectile()
    {

        transform.Rotate(new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), Random.Range(-5, 5)) * 100f * Time.deltaTime, Space.Self);
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerScript>().TakeDamage(damage);
            Destroy(this.gameObject);
        }
    }
}
