using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawner : MonoBehaviour
{
    [SerializeField] private Attacker attackerPrefab;
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
       Attacker newAttacker = Instantiate
           (attackerPrefab, transform.position, transform.rotation);
       newAttacker.transform.parent = transform;
    }


    // Update is called once per frame
    void Update()
    {
    }
}