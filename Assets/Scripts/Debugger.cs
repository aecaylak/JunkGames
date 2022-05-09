using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Debugger : MonoBehaviour
{
    [SerializeField] private GameObject spawner;
    [SerializeField] private GameObject karakter;
    [SerializeField] private GameObject destroyer;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(spawner.transform.position.z - karakter.transform.position.z);
        Debug.Log(karakter.transform.position.z - destroyer.transform.position.z);

    }
}
