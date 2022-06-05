using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
using GoogleMobileAds.Api;
using GoogleMobileAds.Common;


public class AddAds : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    [SerializeField] GameObject resumeButton;
    private RewardedAd rewardedAd;
    

    private ScoreManager scoreManager;
    string adUnitId;
    void Start()
    {
        this.rewardedAd = new RewardedAd(adUnitId);
        scoreManager = gameObject.GetComponent<ScoreManager>();
        

#if UNITY_ANDROID
        adUnitId = "ca-app-pub-3940256099942544/5224354917";
#elif UNITY_IPHONE
        adUnitId"ca-app-pub-3940256099942544/1712485313";

#endif
        this.rewardedAd.OnUserEarnedReward += giveReward;
    }



    public void PlayRewarder()
    {
        Destroy(resumeButton);
        gameOverPanel.SetActive(false);
        this.rewardedAd = new RewardedAd(adUnitId);
        AdRequest request = new AdRequest.Builder().Build();
        this.rewardedAd.LoadAd(request);
        if (this.rewardedAd.IsLoaded())
        {
            this.rewardedAd.Show();
        }
    

    }
    
    private void giveReward(object sender, Reward e)
    {
        RewardResume();
    }
    public void RewardResume()
    {
        gameOverPanel.SetActive(false);

    }
 
}
