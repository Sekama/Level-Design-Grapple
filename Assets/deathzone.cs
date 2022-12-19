using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathzone : MonoBehaviour
{
  public static int staticDeathCount;
  public TMP_Text deathCountText;
  
  
  private void OnTriggerEnter (Collider collider)
  {
    if (collider.gameObject.tag == "Player")
    {
      collider.transform.position = GameObject.Find("Spawn").transform.position;
      collider.transform.GetComponent<Rigidbody>().velocity = Vector3.zero;
      deathCountText = GameObject.Find("Text - DeathCount").GetComponent<TMP_Text>();
      staticDeathCount++;
      deathCountText.text = "Death Count: " + staticDeathCount.ToString();
    }
  }
}


