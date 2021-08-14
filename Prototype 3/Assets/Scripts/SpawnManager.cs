using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject obstaclePrefab;
    private Vector3 spawnPosition = new Vector3 (35, 1, 0);
    
    void Start()
    {
        Instantiate(obstaclePrefab, spawnPosition, obstaclePrefab.transform.rotation);
    }

    
    void Update()
    {
        
    }
}
