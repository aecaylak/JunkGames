using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelStart : MonoBehaviour
{
    private float x = 0;


    void Update()
    {
        if (x < 1)
        {
            Time.timeScale = x;
            Debug.Log(x);
            x += 0.025f;
        }
    }


}
