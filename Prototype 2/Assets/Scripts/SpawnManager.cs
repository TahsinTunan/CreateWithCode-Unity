using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private List<GameObject> animalPrefabs;
    [SerializeField] private float xRange = 15;
    [SerializeField] private float zLocation = 20;
    // private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    void Start()
    {
        StartCoroutine(InstantiateRandomlyCoroutine(animalPrefabs));
    }


    IEnumerator InstantiateRandomlyCoroutine(List<GameObject> prefabs)
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnInterval);
            InstantiateRandomly(prefabs);
        }
    }

    void InstantiateRandomly(List<GameObject> prefabs)
    {
        int randomIndex = Random.Range(0, prefabs.Count);
        float randomLocationX = Random.Range(-xRange, xRange);
        var spawnLocation = new Vector3(randomLocationX, 0, zLocation);
        Instantiate(prefabs[randomIndex], spawnLocation, prefabs[randomIndex].transform.rotation);
    }
}
