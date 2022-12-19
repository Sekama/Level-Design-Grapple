using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TimeTrial : MonoBehaviour
{
   private bool stopWatchActive = false;
   private float currentTime;
   public TMP_Text timeText;


   private void Start()
   {
      currentTime = 0;
      stopWatchActive = true;
   }

   private void Update()
   {
      if (stopWatchActive == true)
      {
         currentTime = currentTime + Time.deltaTime;
      }

      TimeSpan time = TimeSpan.FromSeconds(currentTime);
      timeText.text = time.ToString(@"m\:ss\:ff");
   }

   public void StartStopWatch()
   {
      stopWatchActive = true;
   }

   public void StopStopWatch()
   {
      stopWatchActive = false;
   }
}
