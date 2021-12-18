using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravestone : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D otherCollider)
    {
        //Animator animator = GetComponent<Animator>();
        Attacker attacker = otherCollider.GetComponent<Attacker>();
        if (attacker)
        {
            // create animator state change
            //animator.SetTrigger("underAttack");
        }
    }
}