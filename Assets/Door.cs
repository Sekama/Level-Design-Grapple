using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Key key;
    public Animator anim;
    public Animator deathCountAnim;
    public TimeTrial timeTrial;
    private void Start()
    {
        key = transform.Find("Key").GetComponent<Key>();
        timeTrial = transform.Find("Text - Time").GetComponent<TimeTrial>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player" && key.hasKey == true)
        {
            timeTrial.StopStopWatch();
            anim.SetTrigger("Win");
            deathCountAnim.SetTrigger("Win");
        }
    }
}
