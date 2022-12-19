using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public bool hasKey = false;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            hasKey = true;
            this.GetComponent<MeshRenderer>().enabled = false;
        }
    }
}
