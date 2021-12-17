using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] private Attacker[] attackerPrefabs;
    [SerializeField] private float minTimeToSpawn = 1f;
    [SerializeField] private float maxTimeToSpawn = 5f;
    private bool spawn = true;


    // Start is called before the first frame update
    IEnumerator Start()
    {
        while (spawn)
        {
            yield return new WaitForSeconds(Random.Range(minTimeToSpawn, maxTimeToSpawn));
            SpawnEnemies();
        }
    }

    private void SpawnEnemies()
    {
       var attackerIndex = Random.Range(0,attackerPrefabs.Length);
        Spawn(attackerPrefabs[attackerIndex]);
    }

    private void Spawn(Attacker myAttacker)
    {
        Attacker newAttacker = Instantiate
            (myAttacker, transform.position, transform.rotation);
        newAttacker.transform.parent = transform;
    }
}