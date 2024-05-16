using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "Wave", menuName = "ScriptableObjects/Enemy", order = 4)]
public class EnemyScriptable : ScriptableObject
{
    [field: SerializeField]
    public float health { get; private set; }

    [field: SerializeField]
    public float damage { get; private set; }

}
