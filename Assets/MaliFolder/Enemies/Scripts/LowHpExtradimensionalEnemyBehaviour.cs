using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LowHpExtradimensionalEnemyBehaviour : BaseEnemy
{

    private Vector3[] Direction = new [] { new Vector3(0,4,7),new Vector3(0,1,-7),new Vector3(0,6,3),new Vector3(0,-6,6)};

    private int i = 0;

   
    public LowHpExtradimensionalEnemyBehaviour() : base() 
    {}

 
    



    // Update is called once per frame
    void FixedUpdate()
    {
            
        

        MoveToPoint(transform.position,Direction[i],1);
        

        if((Direction[i] - transform.position).sqrMagnitude < 0.1 )
        {
            i++;
        }

      
        
        
    }



}
