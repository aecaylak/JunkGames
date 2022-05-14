using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bossMovement : MonoBehaviour
{
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject boss;


    private int lineSelected;
    private int lineDirection;
    public float switchLine; // Saða sola geçiþ sýklðý.
    public float obstacleHeight; 
    public float obstDensity; //default 0.4f idi mevcut durumda 0.8f'e çýkarýldý. = her 0.8 saniyede bir obstacle spawn ediliyor.
    public GameObject[] obstacles;

    void Start()
    {

        InvokeRepeating("Spawner", .2f, Random.Range(obstDensity - 0.1f, obstDensity + 0.1f)); //bunlarý Coroutine ile yapsak daha iyi olur sanýrým ama yinede çalýþýyor :) .
        InvokeRepeating("bossMove", .2f, switchLine); 
    }
    void Update()
    {
        
        transform.position =
            new Vector3(transform.position.x, transform.position.y, character.transform.position.z + 13f);
    }

    void bossMove()
    {
        lineSelected = Random.Range(0, 3);

        if (lineSelected == 0) //kod güzelleþtirilebilir
        {
            lineDirection = -2;
            transform.DOLocalMoveX(lineDirection, 0.5f);

        }
        else if (lineSelected == 1)
        {
            lineDirection = 0;
            transform.DOLocalMoveX(lineDirection, 0.5f);

        }
        else if (lineSelected == 2)
        {
            lineDirection = 2;
            transform.DOLocalMoveX(lineDirection, 0.5f);

        }
    }
    void Spawner()
    {
        Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(boss.transform.position.x, obstacleHeight, boss.transform.position.z - 1.5f), Quaternion.identity);
    }   // position y'de random seçilen obsatacle'ýn position'unu alsýn istedim yapamadým. 


}

