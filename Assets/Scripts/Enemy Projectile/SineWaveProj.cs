using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SineWaveProj : EnemyProjectile
{
    public float MoveSpeed = 5.0f;

    public float frequency = 5.0f;  // Speed of sine movement
    public float magnitude = 2f;   // Size of sine movement
    private Vector3 axis;

    private Vector3 pos;

    void Start()
    {
        pos = transform.position;
        Object.Destroy(gameObject, 10.0f);
        axis = transform.up;  // May or may not be the axis you want

    }

    void Update()
    {
        pos += -transform.right * Time.deltaTime * MoveSpeed;
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude;
        CheckDestroy();
    }
    
}
