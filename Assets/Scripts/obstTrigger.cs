using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            //Destroy(other.gameObject); //kesinlikle degistirilebilir
            GameOver();
        }

    }

    void GameOver()
    {
        Time.timeScale = 0;
    }
}
