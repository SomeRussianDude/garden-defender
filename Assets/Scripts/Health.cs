using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float health = 300;
    [SerializeField] private GameObject deathEffect;

    public float GetHealth => health;

    public void DealDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        TriggerDeathEffects();
        Destroy(gameObject);
    }

    private void TriggerDeathEffects()
    {
        if (deathEffect)
        {
            GameObject deathEffectObject = Instantiate(deathEffect, transform.position, transform.rotation);
            Destroy(deathEffectObject,2f);
        }
    }
}