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

}
