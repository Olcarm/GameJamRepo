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

    private void Start()
    {
        SetBlueText();
        SetRedText();
    }

    public void SetEnemytoBlue()
    {
        gameDifficulty.CurrentEnemy = 0;
    }
    public void SetEnemytoRed()
    {
        gameDifficulty.CurrentEnemy = 1;
    }
    private void SetBlueText()
    {
        switch (gameDifficulty.Blue)
        {
            case -1:
                blueText.text = "10% Increased Number of Enemies";
                break;
            case -2:
                blueText.text = "15% Increased Number of Enemies";
                break;
            case -3:
                blueText.text = "20% Increased Number of Enemies";
                break;
            case -4:
                blueText.text = "25% Increased Number of Enemies";
                break;
        }
        switch (gameDifficulty.RedPower)
        {
            case 1:
                blueText.text += "\n+5% Red Enemy Ships";
                break;
            case 2:
                blueText.text += "\n+5% Red Enemy Ships";
                break;
            case 3:
                blueText.text += "\n+5% Red Enemy Ships";
                break;
            case 4:
                blueText.text += "\n+5% Red Enemy Ships";
                break;
        }
    }
    private void SetRedText()
    {
        switch (gameDifficulty.Red)
        {
            case -1:
                redText.text = "10% Increased Number of Enemies";
                break;
            case -2:
                redText.text = "15% Increased Number of Enemies";
                break;
            case -3:
                redText.text = "20% Increased Number of Enemies";
                break;
            case -4:
                redText.text = "25% Increased Number of Enemies";
                break;
        }
        switch (gameDifficulty.BluePower)
        {
            case 1:
                redText.text += "\n+5% Blue Enemy Ships";
                break;
            case 2:
                redText.text += "\n+5% Blue Enemy Ships";
                break;
            case 3:
                redText.text += "\n+5% Blue Enemy Ships";
                break;
            case 4:
                redText.text += "\n+5% Blue Enemy Ships";
                break;
        }
    }
}
