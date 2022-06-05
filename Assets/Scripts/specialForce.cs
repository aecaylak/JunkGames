using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specialForce : MonoBehaviour
{
    public GameObject tracker;
    public GameObject player;

    public float moveSpeed = 20f; //hareket hızı
    private Rigidbody _rb;
    private void Start()
    {
        tracker = GameObject.FindGameObjectWithTag("tracker");
        player = GameObject.FindGameObjectWithTag("shooter");
        _rb = GetComponent<Rigidbody>();
        transform.position = new Vector3(player.transform.position.x, transform.position.y, transform.position.z + 1f);
        
    }
    
    private void FixedUpdate()
    {
        _rb.velocity = new Vector3(0, 0, moveSpeed); //hiz
        transform.position = new Vector3(tracker.transform.position.x, transform.position.y, transform.position.z); //boss takibi
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            Destroy(other.gameObject);
        }

        if (other.gameObject.tag == "tracker")
        {
            Destroy(gameObject);
        }
    }

}
