using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public GameObject battle;
    public GameObject upgrades;
    public GameObject mainButtons;
    public TextMeshProUGUI levelText;
    public TextMeshProUGUI pointsText;
    public GameObject settings;
    [SerializeField]
    private Player player;
    public void Update()
    {
        levelText.text = "Level: " + player.level;
        pointsText.text = "Available Points: " + player.Points;
    }
    public void SetMenutoBattle()
    {
        battle.SetActive(true);
        upgrades.SetActive(false);
        mainButtons.SetActive(false);
    }
    public void SetMenutoUpgrades()
    {
        upgrades.SetActive(true);
        mainButtons.SetActive(false);
    }
    public void BackToMain()
    {
        battle.SetActive(false);
        upgrades.SetActive(false);
        settings.SetActive(false);
        mainButtons.SetActive(true);
    }
    public void Settings()
    {
        settings.SetActive(true);
        mainButtons.SetActive(false);
    }
    public void StartGame()
    {
        BackToMain();
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1;
    }
    public void ExitGame()
    {
        Application.Quit();
    }
}
