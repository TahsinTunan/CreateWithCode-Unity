using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> animalPrefabs;
    [SerializeField] private float xRange = 15;
    [SerializeField] private float zLocation = 20;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        InvokeRepeating("InstantiateRandomly", startDelay, spawnInterval);
    }

    void Update()
    {
        
    }

    // void InstantiateRandomly(List<GameObject> prefabs)
    // {
    //     int randomIndex = Random.Range(0, prefabs.Count);
    //     float randomLocationX = Random.Range(-xRange, xRange);
    //     var spawnLocation = new Vector3 (randomLocationX, 0, zLocation);

    //     Instantiate(prefabs[randomIndex], spawnLocation, prefabs[randomIndex].transform.rotation);
    // }

    void InstantiateRandomly()
    {
        int randomIndex = Random.Range(0, animalPrefabs.Count);
        float randomLocationX = Random.Range(-xRange, xRange);
        var spawnLocation = new Vector3 (randomLocationX, 0, zLocation);

        Instantiate(animalPrefabs[randomIndex], spawnLocation, animalPrefabs[randomIndex].transform.rotation);
    }
}
