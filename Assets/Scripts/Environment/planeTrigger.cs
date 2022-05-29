using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class planeTrigger : MonoBehaviour
{
    public float transFark = 30.0f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {        
            //StartCoroutine("CreatePlane");
            gameObject.transform.parent.position = new Vector3(0, 0, gameObject.transform.position.z + transFark);
        }
    }
/*
    IEnumerator CreatePlane()
    {
        yield return new WaitForSeconds(1f);
        gameObject.transform.parent.position = new Vector3(0, 0, gameObject.transform.position.z + 90);
    }*/
}
