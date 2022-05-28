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
    public GameObject gameover;

    int scoreCount ;

    private void Update()
    {
        score.text = scoreCount.ToString();
        if (Time.timeScale == 1)
        {
            scoreBoard.transform.position = scoring.transform.position;
            scoreCount += 1; 
        }else if (gameover.activeInHierarchy == true) 
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
