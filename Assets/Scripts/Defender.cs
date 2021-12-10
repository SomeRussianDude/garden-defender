using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{
    [SerializeField] private GameObject projectile, gun;
    

    private void Shoot()
    {
        Instantiate(projectile, gun.transform.position, Quaternion.identity);
    }
}
