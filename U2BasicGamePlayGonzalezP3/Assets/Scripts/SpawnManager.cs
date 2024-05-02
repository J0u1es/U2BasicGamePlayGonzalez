using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    private float spawnRangeX = 17;
    private float spawnPosZ = 20;
    public GameObject[] animalPrefabs;
    private float spawnInterval = 1.5f;
    private float startDelay = 2;
    public float sideSpawnMinZ;
    public float sideSpawnMaxZ;
    public float sideSpawnX;

        // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void SpawnRandomAnimal() 
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    void SpawnRightAnimal()
    {

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(sideSpawnX, 0, Random.Range(sideSpawnMinZ,
        sideSpawnMaxZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);

    }
    void SpawnLeftAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(-sideSpawnX, 0, Random.Range(sideSpawnMinZ,
        sideSpawnMaxZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(rotation));
    }
}

