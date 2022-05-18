using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColObstTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(gameObject);
        }
    }
}
