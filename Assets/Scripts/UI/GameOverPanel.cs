using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverPanel : MonoBehaviour
{
    [SerializeField] GameObject gameoverPanel;

    public void ResumeAfterGameOver()
    {
        gameoverPanel.SetActive(false);
        Time.timeScale = 1f;
    }
}
