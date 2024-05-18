using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
[CreateAssetMenu(fileName = "Wave", menuName = "ScriptableObjects/Difficulty", order = 3)]
public class GameDifficulty : ScriptableObject
{

	[SerializeField]
	private float blueState;
    [SerializeField]
    private float bluePower;
    [SerializeField]
    private float redState;
    [SerializeField]
    private float redPower;
    [SerializeField]
    private float currentEnemy;

    public float Blue
	{
		get { return blueState; }
		set { blueState = value; }
	}
    public float BluePower
    {
        get { return bluePower; }
        set { bluePower = value; }
    }
    public float Red
    {
        get { return redState; }
        set { redState = value; }
    }
    public float RedPower
    {
        get { return redPower; }
        set { redPower = value; }
    }
    public float CurrentEnemy
    {
        get { return currentEnemy; }
        set { currentEnemy = value; }
    }
    
}
