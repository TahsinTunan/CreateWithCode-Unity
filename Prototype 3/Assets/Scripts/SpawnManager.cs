using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    [SerializeField] private float delayInSecond = 1.5f;
    private Vector3 spawnPosition = new Vector3 (35, 1, 0);
    
    void Start()
    {
        StartCoroutine(delayedSpawn(delayInSecond, obstaclePrefab, spawnPosition));
    }

    
    void Update()
    {
        
    }

    IEnumerator delayedSpawn(float delay, GameObject prefab, Vector3 spawnPosition)
    {
        while(true){
            Instantiate(prefab, spawnPosition, prefab.transform.rotation);
            yield return new WaitForSeconds(delay);
        }
    }
}
