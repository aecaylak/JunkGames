using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shooter : MonoBehaviour
{
   
    [SerializeField] GameObject mermi;
    private Vector3 _vec;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            _vec = new Vector3(transform.position.x, transform.position.y, transform.position.z + 1f);
            Instantiate(mermi, _vec, Quaternion.identity);
            Debug.Log("Instantiated");
        }
    }
}
