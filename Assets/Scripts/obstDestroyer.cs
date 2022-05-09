using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obstDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject character;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
        }
    }
    void Update()
    {

        transform.position =
            new Vector3(transform.position.x, transform.position.y, character.transform.position.z - 8);
    }

    
}
