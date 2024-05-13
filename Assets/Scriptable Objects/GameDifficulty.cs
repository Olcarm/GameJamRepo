using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class GameDifficulty : ScriptableObject
{

	[SerializeField]
	private float blueState;

    [SerializeField]
    private float redState;

    public float Blue
	{
		get { return blueState; }
		set { blueState = value; }
	}
    public float Red
    {
        get { return redState; }
        set { redState = value; }
    }

}
