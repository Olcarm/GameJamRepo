using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoundProjectile : EnemyProjectile
{

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = -transform.right * projSpeed;
        RotateProjectile();
    }



    void Update()
    {
        CheckDestroy();
    }
}
