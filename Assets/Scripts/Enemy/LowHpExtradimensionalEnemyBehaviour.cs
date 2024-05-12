using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowHpExtradimensionalEnemyBehaviour : BaseEnemy
{

    private Vector3[] Direction = new [] { new Vector3(0,4,7),new Vector3(0,1,-7),new Vector3(0,6,3),new Vector3(0,-6,6)};

    private int i = 0;
    private Vector3[] Points; 
    

   
    public LowHpExtradimensionalEnemyBehaviour() : base() 
    {}

 
    void Start()
    {

       Points = ConvertPoints();



    }



    // Update is called once per frame
    void FixedUpdate()
    {
            
        

        MoveToPoint(transform.position,Points[i],speed);
        

        if((Points[i] - transform.position).sqrMagnitude < 0.5 )
        {
            i++;

            if(i>=Points.Length)
            {
                i = 0;
            }
                        
        }

        ShootProjectile();
       
        
    }



}
