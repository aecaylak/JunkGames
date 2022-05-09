using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstSpawner : MonoBehaviour
{
    [SerializeField] private GameObject character;
    public GameObject[] engeller;
    private int lineSelected;
    private int lineDirection;
    public float obstDensity = 0.4f; //default: 0.4

    void Start()
    {
        InvokeRepeating("Spawner", obstDensity, Random.Range(obstDensity - 0.1f, obstDensity + 0.1f));
    }
    void Update()
    {
        transform.position =
            new Vector3(transform.position.x, transform.position.y, character.transform.position.z + 11.5f);
    }

    void Spawner()
    {
        lineSelected = Random.Range(0, 3);
        
        if (lineSelected == 0) //kod güzelleştirilebilir
        {
            lineDirection = -2;
        }else if (lineSelected == 1)
        {
            lineDirection = 0;
        }else if (lineSelected == 2)
        {
            lineDirection = 2;
        }
        
        Instantiate(engeller[Random.Range(0, engeller.Length)],new Vector3(lineDirection, transform.position.y, transform.position.z), Quaternion.identity);


    }
}
