using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{

    public int Hp = 110;
    private int dmg = 210;

    public GameObject PointsObject;
    
  

    public void MoveToPoint(Vector3 CurrentPosition, Vector3 Destination, float speed){


        

        transform.position = Vector3.Slerp(CurrentPosition,Destination,speed*Time.deltaTime);
        

    }


    

    public Vector3[] ConvertPoints(){

        int i = PointsObject.transform.childCount;
        Vector3[] Points = new Vector3[i];
        

        for(int j = 0;j!=i;j++){
            Points[j] = PointsObject.transform.GetChild(j).transform.position;
        }

        return Points;

    }







}
