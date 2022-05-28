using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManager : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject levelsMenu;
    [SerializeField] GameObject credits;
    [SerializeField] GameObject options;

    public void NextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Time.timeScale = 1f;
    }

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
    public void CloseOptionsPanel()
    {
        options.SetActive(false);
    }


    //LEVELS

    public void WaterLand()
    {
        SceneManager.LoadScene(1);
    }public void EarthLand()
    {
        SceneManager.LoadScene(2);
    }public void AirLand()
    {
        SceneManager.LoadScene(3);
    }public void FireLand()
    {
        SceneManager.LoadScene(4);
    }public void JunkLand()
    {
        SceneManager.LoadScene(5);
    }
}



