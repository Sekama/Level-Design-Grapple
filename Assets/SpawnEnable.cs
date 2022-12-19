using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpawnEnable : MonoBehaviour
{
    public GameObject[] spawnPoint;

    public GameObject childSpawn;


    private void Awake()
    {
        spawnPoint = new GameObject[10];
        spawnPoint = GameObject.FindGameObjectsWithTag("Spawn");
        childSpawn = gameObject.transform.GetChild(0).gameObject;
    }

    private void Start()
    {
        foreach (GameObject spawnPoint in spawnPoint)
        {
             spawnPoint.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            foreach (GameObject spawnPoint in spawnPoint)
            {
                spawnPoint.SetActive(false);
            }
            childSpawn.SetActive(true);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            Time.timeScale = 1;
        }
    }
}
