using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject menu,levelsMenu,credits,options,playerInputPanel,leaderBoard;


    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

    //Main Menu
    public void Menu()
    {
        menu.SetActive(true);
    }

    public void CloseMenu()
    {
        menu.SetActive(false);
    }

    public void LevelsPanel()
    {
        levelsMenu.SetActive(true);

    }
    public void CloseLevelsPanel()
    {
        levelsMenu.SetActive(false);
        menu.SetActive(true);

    }
    public void CreditsPanel()
    {
        credits.SetActive(true);
    }
    
    public void CloseCreditsPanel()
    {
        credits.SetActive(false);
    }
    public void OptionsPanel()
    {
        options.SetActive(true);
    }
    public void PlayerInput()
    {
        playerInputPanel.SetActive(true);
    }  public void CloseplayerInput()
    {
        playerInputPanel.SetActive(false);
    }
    public void CloseOptionsPanel()
    {
        options.SetActive(false);
    }

    public void OpenLeaderBoardPanel()
    {
        leaderBoard.SetActive(true);
    }
    public void CloseLeaderBoardPanel()
    {
        leaderBoard.SetActive(false);
    }


    //LEVELS

    public void WaterLand()
    {
        SceneManager.LoadScene(13);
        Time.timeScale = 1;
    }public void EarthLand()
    {
        SceneManager.LoadScene(16);
        Time.timeScale = 1;
    }
    public void AirLand()
    {
        SceneManager.LoadScene(19);
        Time.timeScale = 1;
    }
    public void FireLand()
    {
        SceneManager.LoadScene(22);
        Time.timeScale = 1;
    }
    public void JunkLand()
    {
        SceneManager.LoadScene(24);
        Time.timeScale = 1;
    }
}



