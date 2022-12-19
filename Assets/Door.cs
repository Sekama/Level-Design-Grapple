using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Key key;
    
    private void Start()
    {
        key = transform.Find("Key").GetComponent<Key>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player" && key.hasKey == true)
        {
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
