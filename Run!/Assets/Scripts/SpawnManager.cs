using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] farmerPrefabs;
    private float spawnPosX = 1.0f;
    private float spawnRangeZ1 = 3.5f;
    private float spawnRangeZ2 = 8.5f;
    private float startDelay = 2f;
    private float spawnInterval = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomFarmers", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        SpawnRandomFarmers();
    }

    void SpawnRandomFarmers()
    {
        int farmerIndex = Random.Range(0, farmerPrefabs.Length);
        Vector3 spawnPos = new Vector3(spawnPosX, -8, Random.Range(-spawnRangeZ1, -spawnRangeZ2));
        //Instantiate(farmerPrefabs[farmerIndex], spawnPos, farmerPrefabs[farmerIndex].transform.rotation);
    }
}
