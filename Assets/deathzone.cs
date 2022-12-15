using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathzone : MonoBehaviour
{
  public GameObject spawnPoint;
  
  
  private void OnTriggerEnter (Collider collider)
  {
    if (collider.gameObject.tag == "Player")
    {
      collider.transform.position = spawnPoint.transform.position;
    }
  }
}


