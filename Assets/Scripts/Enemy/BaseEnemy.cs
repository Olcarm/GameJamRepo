using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseEnemy : MonoBehaviour
{

    public float health;
    public float speed = 3;
    public float AttackSpeed = 3;



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


    public void TakeDamage(float damage)
    {
        health -= damage;
        if(health<=0)
        {
            Destroy(gameObject);
        }
        
        
    }









}
