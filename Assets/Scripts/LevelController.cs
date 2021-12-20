using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    private int numberOfAttackers = 0;
    private bool levelTimerFinished = false;

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
            Debug.Log("Level Complete!");
        }
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