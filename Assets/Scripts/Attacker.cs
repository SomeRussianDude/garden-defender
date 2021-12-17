using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
   [Range (0f, 5f)] [SerializeField] private float walkSpeed = 1f;
   private GameObject currentTarget;
   private Animator animator;

   private void Start()
   {
       animator = GetComponent<Animator>();
   }

   void Update()
    {
        Move();
        UpdateAnimationState();
    }

   private void UpdateAnimationState()
   {
       if (!currentTarget)
       {
           animator.SetBool("isAttacking", false);
       }   }

   private void Move()
    {
        transform.Translate(Vector2.left * walkSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        walkSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        animator.SetBool("isAttacking", true);
        currentTarget = target;
    }

    public void StrikeCurrentTarget(float damage)
    {
        if (!currentTarget)
        {
            return;
        }

        Health health = currentTarget.GetComponent<Health>();
        if (health)
        {
            health.DealDamage(damage);
        }
    }
}