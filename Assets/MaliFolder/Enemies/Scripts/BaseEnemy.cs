using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{

    public int Hp = 110;
    private int dmg = 210;

  

    public void MoveToPoint(Vector3 CurrentPosition, Vector3 Destination, float speed){

        transform.position = Vector3.Lerp(CurrentPosition,Destination,speed*Time.deltaTime);
        

    }





}
