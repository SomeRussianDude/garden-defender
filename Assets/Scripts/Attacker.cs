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
    }

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
}