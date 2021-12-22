using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    [SerializeField] private GameObject winLabel;
    private int numberOfAttackers = 0;
    private bool levelTimerFinished = false;


    private void Start()
    {
        winLabel.SetActive(false);
    }

    public void LevelTimerFinished()
    {
        levelTimerFinished = true;
        StopSpawners();
    }

    public void AttackerSpawned()
    {
        numberOfAttackers++;
    }

    public void AttackerKilled()
    {
        numberOfAttackers--;
        if (numberOfAttackers <= 0 && levelTimerFinished)
        {
            StartCoroutine(HandleWin());
        }
    }

    private IEnumerator HandleWin()
    {
        winLabel.SetActive(true);
        GetComponent<AudioSource>().Play();
        yield return new WaitForSeconds(4f);
        GetComponent<LevelLoader>().LoadNextScene();
    }


    private void StopSpawners()
    {
        AttackerSpawner[] spawnersArray = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in spawnersArray)
        {
            spawner.StopSpawning();
        }
    }
}