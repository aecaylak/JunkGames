using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
   
    [SerializeField] GameObject mermi;
    private Vector3 _vec;
    private bool sorgu = false;
    private AudioSource Audio;
    public AudioClip[] AudiosList;

    private void Start()
    {
        Audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _vec = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
            Instantiate(mermi, _vec, Quaternion.identity);
            Audio.clip = AudiosList[0]; //Oynatmak için listeden audio seç.
            Audio.Play();
            StartCoroutine("bekle");
        }

        if (Input.touchCount == 1)
        {
            Touch parmak = Input.GetTouch(0);
            if (parmak.deltaPosition.y < -64.0f && sorgu == false)
            {
                _vec = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
                Instantiate(mermi, _vec, Quaternion.identity);
                Audio.clip = AudiosList[0]; //Oynatmak için listeden audio seç.
                Audio.Play();
                StartCoroutine("bekle");
            }
        }
    }


    IEnumerator bekle() //tekte birden fazla atmasını engelliyoruz.
    {
        sorgu = true;
        yield return new WaitForSeconds(1);
        sorgu = false;
    }
}
