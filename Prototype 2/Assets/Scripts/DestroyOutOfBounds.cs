using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound, bottomBound;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        destroyGameObject();
    }

    void destroyGameObject()
    {
        if (transform.position.z >= topBound || transform.position.z <= bottomBound)
        {
            Destroy(gameObject);
        }
    }
}
