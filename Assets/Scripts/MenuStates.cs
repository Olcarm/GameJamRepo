using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class MenuStates : MonoBehaviour
{
    public TextMeshProUGUI blueText;
    public TextMeshProUGUI redText;

    [SerializeField]
    private GameDifficulty gameDifficulty;
    
    void Update()
    {
        
    }
    public void SetEnemytoBlue()
    {
        gameDifficulty.CurrentEnemy = 0;
    }
    public void SetEnemytoRed()
    {
        gameDifficulty.CurrentEnemy = 1;
    }
}
