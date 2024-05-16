using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


[CreateAssetMenu(fileName = "Wave", menuName = "ScriptableObjects/Player", order = 2)]
public class Player : ScriptableObject
{
    [field: SerializeField]
    public int level;

    [field: SerializeField]
    public float experience;

    [field: SerializeField]
    public int availablePoints;

    [field: SerializeField]
    public float health;

    [field: SerializeField]
    public float damage;

    [field: SerializeField]
    public float speed;

    [field: SerializeField]
    public float attackRate;

    public int Level
    {
        get { return level; }
        set { level = value; }
    }

    public float Experience
    {
        get { return experience; }
        set { experience = value; }
    }

    public int Points
    {
        get { return availablePoints; }
        set { availablePoints = value; }
    }
    public float Health
    {
        get { return health; }
        set { health = value; }
    }
    public float Damage
    {
        get { return damage; }
        set { damage = value; }
    }
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    public float AttackRate
    {
        get { return attackRate; }
        set { attackRate = value; }
    }
}
