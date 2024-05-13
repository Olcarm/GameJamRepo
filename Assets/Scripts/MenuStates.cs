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
    void Start()
    {
        
    }

    
    void Update()
    {
        blueText.text = gameDifficulty.Blue + "";
        redText.text = gameDifficulty.Red + "";
    }
}
