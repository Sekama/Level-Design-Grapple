using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class gameStart : MonoBehaviour
{
   public Image gameStartPanel;
   public TMP_Text gameStartText;


   private void Awake()
   {
      Time.timeScale = 0;
   }

   private void Update()
   {
      if (Input.GetKeyDown(KeyCode.Space))
      {
         Time.timeScale = 1;
         gameStartPanel.enabled = false;
         gameStartText.enabled = false;
      }
   }
}
