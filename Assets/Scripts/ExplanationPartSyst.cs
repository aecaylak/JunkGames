using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplanationPartSyst : MonoBehaviour
{
    private ParticleSystem _particle;

    private void Start()
    {
        _particle = GetComponent<ParticleSystem>();
        _particle.Stop();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Obstacle")
        {
            _particle.Play();
        }

        if (other.gameObject.tag == "tracker")
        {
            _particle.Play();
        }
    }
}
