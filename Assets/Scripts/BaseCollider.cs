using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCollider : MonoBehaviour
{
    private void Start()
    {
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var healthDisplay = FindObjectOfType<HealthDisplay>();
        Attacker attacker = otherCollider.GetComponent<Attacker>();
        if (attacker)
        {
            healthDisplay.LoseLife();
        }
    }
}
