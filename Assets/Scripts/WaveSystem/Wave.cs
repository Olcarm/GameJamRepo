using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Wave", menuName = "ScriptableObjects/Waves", order = 1)]
public class Wave : ScriptableObject
{

    [field: SerializeField]
    public GameObject[] BlueEnemiesInWave { get; private set; }
    
    [field: SerializeField]
    public int[] BlueEnemyCosts { get; private set; }

    [field: SerializeField]
    public GameObject[] RedEnemiesInWave { get; private set; }

    [field: SerializeField]
    public int[] RedEnemyCosts { get; set; }

    [field: SerializeField]
    public float TimeBeforeThisWave { get; private set; }

    [field: SerializeField]
    public float EnemyTotalCost;

    public float TotalCost
    {
        get { return EnemyTotalCost; }
        set { EnemyTotalCost = value; }
    }
    

}
