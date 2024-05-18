using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameMenuScript : MonoBehaviour
{
    private bool isGamePaused = false;
    [SerializeField]
    private GameObject pauseMenu;
    [SerializeField]
    private GameObject menu;
    [SerializeField]
    private GameObject settingsMenu;
    [SerializeField]
    private GameObject defeatScreen;
    [SerializeField]
    private GameDifficulty difficulty;
    [SerializeField]
    private Player player;
     
    

    public void PauseGame()
    {
        pauseMenu.gameObject.SetActive(true);
        Time.timeScale = 0;
        isGamePaused = true;
    }

    public void ContinueGame()
    {
        pauseMenu.gameObject.SetActive(false);
        Time.timeScale = 1;
        isGamePaused = false;
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isGamePaused)
            {
                ContinueGame();
            }
            else
            {
                PauseGame();
            }

        }
    }
    
    public void BackButton()
    {
        settingsMenu.SetActive(false);
        menu.SetActive(true);
    }

    public void Settings()
    {
        settingsMenu.SetActive(true);
        menu.SetActive(false);
    }
    public void DefeatScreen()
    {
        defeatScreen.SetActive(true);
        settingsMenu.SetActive(false);
        menu.SetActive(false);
    }
    public void Defeat()
    {
        if(difficulty.CurrentEnemy == 0)
        {
            if(difficulty.Blue > -4 && difficulty.Blue != 0)
            {
                difficulty.Blue += 1;
            }
            if(difficulty.RedPower < 4)
            {
                difficulty.RedPower += 1;
            }
        }
        else
        {
            if(difficulty.Red > -4 && difficulty.Red != 0)
            {
                difficulty.Red += 1;
            }
            if (difficulty.BluePower < 4)
            {
                difficulty.BluePower += 1;
            }
        }
        SceneManager.LoadScene("Menu");
    }
    public void Victory()
    {
        if (difficulty.CurrentEnemy == 0)
        {
            if (difficulty.Blue > -5)
            {
                difficulty.Blue -= 1;
                
            }
            if (difficulty.RedPower < 4)
            {
                difficulty.RedPower += 1;
            }
            if( difficulty.BluePower < 4)
            {
                difficulty.BluePower -= 1;
            }
        }
        else
        {
            if (difficulty.Red > -5)
            {
                difficulty.Red -= 1;
            }
            if (difficulty.BluePower < 4)
            {
                difficulty.BluePower += 1;
            }
            if(difficulty.RedPower < 4)
            {
                difficulty.RedPower -= 1;
            }
        }
        SceneManager.LoadScene("Menu");
        player.level += 1;
        player.availablePoints += 2;
    }
}
