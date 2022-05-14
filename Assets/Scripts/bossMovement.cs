using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class bossMovement : MonoBehaviour
{
    [SerializeField] private GameObject character;
    [SerializeField] private GameObject boss;

    private int oldLine;
    private int lineSelected;
    private int lineDirection;
    public float switchingDensity = 0.85f; // Saga sola gecis sikligi
    public float obstacleHeight; 
    public float obstDensity; //0.4 yaptim degistirilebilir
    public GameObject[] obstacles;

    void Start()
    {

        InvokeRepeating("Spawner", .2f, Random.Range(obstDensity - 0.05f, obstDensity + 0.05f)); //bunlari Coroutine ile yapsak daha iyi olur sanirim ama yinede çalisiyor :) .
        InvokeRepeating("bossMove", .2f, switchingDensity); 
    }
    void Update()
    {
        
        transform.position =
            new Vector3(transform.position.x, transform.position.y, character.transform.position.z + 13f);
    }

    void bossMove()
    {
        oldLine = lineSelected;
        lineSelected = Random.Range(0, 3);
        if (oldLine!=lineSelected)
        {
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
        }else if (oldLine==lineSelected)
        {
            bossMove();
        }
    }
    void Spawner()
    {

        if (transform.position.x == -2 || transform.position.x == 0 || transform.position.x == 2)
        {
            Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(boss.transform.position.x, obstacleHeight, boss.transform.position.z - 1.5f), Quaternion.identity);
            
        }
        else
        {
            if (transform.position.x >= 1)
            {
                Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(2, obstacleHeight, boss.transform.position.z - 1.5f), Quaternion.identity);

            }else if (transform.position.x <1 && transform.position.x >-1)
            {
                Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(0, obstacleHeight, boss.transform.position.z - 1.5f), Quaternion.identity);

            }else if (transform.position.x <= -1)
            {
                Instantiate(obstacles[Random.Range(0, obstacles.Length)], new Vector3(-2, obstacleHeight, boss.transform.position.z - 1.5f), Quaternion.identity);

            }
        }
    }   // position y'de random seçilen obsatacle'in position'unu alsin istedim yapamadým. @saidokur


}

