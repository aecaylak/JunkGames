using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using LootLocker.Requests;
using System;


public class GameManager : MonoBehaviour
{
    public InputField playerNameInputField, PlayerAgeXPInputField;
    public GameObject createPlayerButton, loginButton;
    Guid currentDeviceID;
    public Slider levelSlider;
    public Text currentLevelText, NextLevelText, CurrentXPText;

    public void Start()
    {
      
    }
    public void GiveXP()
    {
        LootLockerSDKManager.SubmitXp(int.Parse(PlayerAgeXPInputField.text), (response) =>
        {
            if (response.success)
            {
                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed" + response.Error);
            }
        });
    }



    public void CreatePlayer()
    {
        currentDeviceID = Guid.NewGuid();
        PlayerPrefs.SetString("GUID", currentDeviceID.ToString());

        LootLockerSDKManager.StartSession(currentDeviceID.ToString(), (response) =>
        {
            if (response.success)
            {

                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed" + response.Error);
            }
        });
    }

    public void Login()
    {
        LootLockerSDKManager.StartSession(PlayerPrefs.GetString("GUID", ""), (response) =>
        {
            if (response.success)
            {
                createPlayerButton.SetActive(false);
                loginButton.SetActive(false);
                playerNameInputField.gameObject.SetActive(false);
                Debug.Log("Success");
            }
            else
            {
                Debug.Log("Failed" + response.Error);
            }
        });
    }
}

