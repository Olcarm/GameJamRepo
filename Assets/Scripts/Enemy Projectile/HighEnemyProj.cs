using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighEnemyProj : MonoBehaviour
{
    [SerializeField]
    private float projSpeed;
    [SerializeField]
    private EnemyScriptable highEnemy;


    private float rotationsPerMinute = 10f;
    void Start()
    {
        Destroy(this.gameObject, 15f);
        
    }

    
    void Update()
    {

        
        transform.position += transform.up * Time.deltaTime * projSpeed;
        
        transform.Rotate(0, 0, 10f * Time.deltaTime * rotationsPerMinute, Space.Self);

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            other.GetComponent<PlayerScript>().TakeDamage(highEnemy.damage);
            Destroy(this.gameObject);
        }
    }
}
