using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collector : MonoBehaviour
{
    private AudioSource Audio;
    public AudioClip[] AudiosList;

   public float WaterAmount, EarthAmount, FireAmount, AirAmount; // Güç barýnda toplanýlan güç puanlarý.
   public Image WaterFilled, EarthFilled, FireFilled, AirFilled; //Canvastaki filled imageler.
    private void Start()
    {
        Audio = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Water"))
        {
            WaterAmount += 5f;          // Güç toplama baþýna güç barýna yansýyacak artýþ.
            WaterFilled.fillAmount = WaterAmount / 100;
            if (WaterFilled.fillAmount > 100)
            {
                WaterFilled.fillAmount = 100;
            }
            Destroy(other.gameObject);

            Audio.clip = AudiosList[0]; //Oynatmak için listeden audio seç.
            Audio.Play();               //Seçileni çal.
        }
        else if (other.gameObject.CompareTag("Earth"))
        {
            EarthAmount += 5f;
            EarthFilled.fillAmount = EarthAmount / 100;
            if (EarthFilled.fillAmount > 100)
            {
                EarthFilled.fillAmount = 100;
            }
            Destroy(other.gameObject);

            Audio.clip = AudiosList[1];
            Audio.Play();
        }
        else if (other.gameObject.CompareTag("Fire"))
        {
            FireAmount += 5f;
            FireFilled.fillAmount = FireAmount / 100;
            if (FireFilled.fillAmount > 100)
            {
                FireFilled.fillAmount = 100;
            }
            Destroy(other.gameObject);

            Audio.clip = AudiosList[2];
            Audio.Play();
        }
        else if (other.gameObject.CompareTag("Air"))
        {
            AirAmount += 5f;
            AirFilled.fillAmount = AirAmount / 100;
            if (AirFilled.fillAmount > 100)
            {
                AirFilled.fillAmount = 100; 
            }
            Destroy(other.gameObject);

            Audio.clip = AudiosList[3];
            Audio.Play();
        }
        
    }
}
