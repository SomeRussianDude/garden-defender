using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float shootingSpeed = 5f;
    [SerializeField] private float damage = 100f;


    void Update()
    {
        Move();
    }


    private void Move()
    {
        transform.Translate(Vector2.right * shootingSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        var health = otherCollider.GetComponent<Health>();
        var attacker = otherCollider.GetComponent<Attacker>();
        if (health && attacker)
        {
            health.DealDamage(damage);
            Hit();
        }
    }

    private void Hit()
    {
        Destroy(gameObject);
    }
}