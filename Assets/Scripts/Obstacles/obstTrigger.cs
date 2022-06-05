using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class obstTrigger : MonoBehaviour
{

    [SerializeField] GameObject gameOverPanel;
    public LeaderBoard scoreCounter;
    public ScoreManager scoreManager;
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            StartCoroutine(DieRoutine());
            Time.timeScale = 0;
            gameOverPanel.SetActive(true);
            Destroy(other.gameObject);
        }


    }

    public void CloseGameOver()
    {
        gameOverPanel.SetActive(false);

        Time.timeScale = 1f;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }


    IEnumerator DieRoutine()
    {
        yield return new WaitForSecondsRealtime(1f);
        yield return scoreCounter.SubmitScoreRoutine(scoreManager.getScoreCount());

    }
}
