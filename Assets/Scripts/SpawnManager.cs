using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] prefabList;
    //public GameObject targetPrefab;
    public float spawnRate = 2f;
    float nextSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        nextSpawnTime = Time.time + spawnRate;
    }

    void Update()
    {
        if (Time.time > nextSpawnTime)
        {
            float randXPos = Random.Range(-12f, 12f);
            Vector3 spawnPos = new Vector3(randXPos, 0, transform.position.z);

            int randPrefabIndex = Random.Range(0, prefabList.Length);
            Instantiate(prefabList[randPrefabIndex], spawnPos, transform.rotation);
            nextSpawnTime = Time.time + spawnRate;
        }
    }
}
