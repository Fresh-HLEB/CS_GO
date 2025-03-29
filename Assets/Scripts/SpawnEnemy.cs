using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour
{
    public GameObject enemy;
    public GameObject[] spawnEnemyPlaces;
    void Start()
    {
        spawnEnemyPlaces = GameObject.FindGameObjectsWithTag("Spawn");
        for(int i = 0; i < spawnEnemyPlaces.Length; i++)
        {
            Vector3 position = spawnEnemyPlaces[i].transform.position + new Vector3(Random.Range(0, 3), Random.Range(0, 3), Random.Range(0, 3));
            Instantiate(enemy, position, Quaternion.identity);
        }
    }
    void Update()
    {
       
    }
}
