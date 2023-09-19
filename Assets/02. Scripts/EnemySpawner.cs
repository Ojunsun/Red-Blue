using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    List<GameObject> spawns = new List<GameObject>();
    [SerializeField]
    List<GameObject> enemyPrefabs = new List<GameObject>();
    [SerializeField]
    private float spawnTime;
    private void Start()
    {
        StartCoroutine(SpawnCoroutine());
    }

    IEnumerator SpawnCoroutine()
    {
        while (true)
        {
            int randomNum = Random.Range(0, spawns.Count);
            int randomEnemy = Random.Range(0, enemyPrefabs.Count);

            Instantiate(enemyPrefabs[randomEnemy], spawns[randomNum].transform);

            yield return new WaitForSeconds(spawnTime);
        }
    }
}
