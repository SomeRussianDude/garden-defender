using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Shooter : MonoBehaviour
{
    [SerializeField] private GameObject projectile, gun;
    private AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetSpawnerLane();
    }

    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("SHOOT!!");
        }
        else
        {
            Debug.Log("Hold it..........");
        }
    }

    private void SetSpawnerLane()
    {
        var attackerSpawners = FindObjectsOfType<AttackerSpawner>();
        foreach (AttackerSpawner spawner in attackerSpawners)
        {
            bool isCloseEnough = (Mathf.Abs(spawner.transform.position.y - transform.position.y) <= Mathf.Epsilon);
            if (isCloseEnough)
            {
                myLaneSpawner = spawner;
            }
        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    private void Shoot()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }
}