using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class obstDestroyer : MonoBehaviour
{
    [SerializeField] private GameObject character;
    
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle" || other.gameObject.tag == "Air" || other.gameObject.tag == "Water" || other.gameObject.tag == "Earth" || other.gameObject.tag == "Fire")
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
