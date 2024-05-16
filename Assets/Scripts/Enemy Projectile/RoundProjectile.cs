using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundProjectile : EnemyProjectile
{

    private Rigidbody rb;
    [SerializeField]
    private EnemyScriptable enemyType;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = -transform.right * projSpeed;
        damage = enemyType.damage;
        
    }



    void Update()
    {
        CheckDestroy();
        RotateProjectile();
    }
}
