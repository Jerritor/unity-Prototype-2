using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;

    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    public GameObject[] animalPrefabs;
    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating(method name, starting delay, method call interval) 
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        //Randomly generate animal index and spawn position
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX),
            0,
            spawnPosZ);

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Instantiate(animalPrefabs[animalIndex],
                    spawnPos,
                    animalPrefabs[animalIndex].transform.rotation);
    }
}
