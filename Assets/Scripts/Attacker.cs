using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] private float walkSpeed = 1f;

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
}