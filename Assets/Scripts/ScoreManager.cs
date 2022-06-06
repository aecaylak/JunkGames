using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text score;
    public GameObject scoreOver;
    public GameObject scoreBoard;
    public GameObject scoring;
    public GameObject gameOverPanel;

    int scoreCount;
    public void Start()
    {
        Time.timeScale = 1;
        score.text = scoreCount.ToString();
    }
    private void Update()
    {
        
        score.text = scoreCount.ToString();
        if (Time.timeScale == 1)

        {
            scoreCount += 1;
           
            scoreBoard.transform.position = scoring.transform.position;
            
        }else if (gameOverPanel.activeInHierarchy == true) 
        {
            scoreBoard.transform.position = scoreOver.transform.position;
        }

    }

    

    public void doubleScoreCount()
    {
        scoreCount  = scoreCount*2;
    }

    public int getScoreCount()
    {
        return scoreCount;
    }
}
