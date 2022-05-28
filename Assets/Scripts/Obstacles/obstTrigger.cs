using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class obstTrigger : MonoBehaviour
{

    [SerializeField] GameObject gameOver;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            //Destroy(other.gameObject); //kesinlikle degistirilebilir
            Time.timeScale = 0;
            gameOver.SetActive(true);
            Destroy(other.gameObject);
        }
        
      
    }

    public void CloseGameOver()
    {
        gameOver.SetActive(false);
 
        Time.timeScale = 1f;
    }

    public void TryAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
