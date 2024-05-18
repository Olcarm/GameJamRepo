using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class MenuStates : MonoBehaviour
{
    public TextMeshProUGUI blueText;
    public TextMeshProUGUI redText;
    public Button blueButton;
    public Button redButton;
    [SerializeField]
    private GameDifficulty gameDifficulty;
    private void Start()
    {
        SetBlueText();
        SetRedText();
    }
    private void Update()
    {
        if(gameDifficulty.Blue == -5)
        {
            blueButton.interactable = false;
            blueText.text = "Enemy Defeated";
        }
        if(gameDifficulty.Red == -5)
        {
            redButton.interactable = false;
            redText.text = "Enemy Defeated";
        }
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
            case 0:
                break;
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
                blueText.text += "\n+10% Red Enemy Ships";
                break;
            case 3:
                blueText.text += "\n+15% Red Enemy Ships";
                break;
            case 4:
                blueText.text += "\n+20% Red Enemy Ships";
                break;
        }
    }
    private void SetRedText()
    {
        switch (gameDifficulty.Red)
        {
            case 0:
                break;
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
                redText.text += "\n+10% Blue Enemy Ships";
                break;
            case 3:
                redText.text += "\n+15% Blue Enemy Ships";
                break;
            case 4:
                redText.text += "\n+20% Blue Enemy Ships";
                break;
        }
    }
}
