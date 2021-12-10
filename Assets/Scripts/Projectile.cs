using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float shootingSpeed = 5f;

    void Update()
    {
        Move();
    }


    private void Move()
    { 
        transform.Translate(Vector2.right * shootingSpeed * Time.deltaTime);
    }
}