using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectorJunk : MonoBehaviour
{
    private AudioSource Audio;
    public AudioClip[] AudiosList;

   public float WaterAmount, EarthAmount, FireAmount, AirAmount; // G�� bar�nda toplan�lan g�� puanlar�.
   public Image WaterFilled, EarthFilled, FireFilled, AirFilled; //Canvastaki filled imageler.
    private void Start()
    {
        Audio = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            WaterAmount += 5f;          // G�� toplama ba��na g�� bar�na yans�yacak art��.
            WaterFilled.fillAmount = WaterAmount / 100;
            if (WaterAmount > 100)
            {
                
              
            }
            Destroy(other.gameObject);

            Audio.clip = AudiosList[0]; //Oynatmak i�in listeden audio se�.
            Audio.Play();               //Se�ileni �al.
        }
        else if (other.gameObject.CompareTag("Earth"))
        {
            EarthAmount += 5f;
            EarthFilled.fillAmount = EarthAmount / 100;
            if (EarthAmount > 100)
            {
               
                
            }
            Destroy(other.gameObject);

            Audio.clip = AudiosList[1];
            Audio.Play();
        }
        else if (other.gameObject.CompareTag("Fire"))
        {
            FireAmount += 5f;
            FireFilled.fillAmount = FireAmount / 100;
            if (FireAmount > 100)
            {
              
            }
            Destroy(other.gameObject);

            Audio.clip = AudiosList[2];
            Audio.Play();
        }
        else if (other.gameObject.CompareTag("Air"))
        {
            AirAmount += 5f;
            AirFilled.fillAmount = AirAmount / 100;
            if (AirAmount > 100)
            {
              
            }
            Destroy(other.gameObject);

            Audio.clip = AudiosList[3];
            Audio.Play();
        }
        
    }
}
