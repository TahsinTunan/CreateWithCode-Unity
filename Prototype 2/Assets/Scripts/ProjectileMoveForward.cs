using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMoveForward : MonoBehaviour
{
    [SerializeField] private float projectileSpeed;

    void Start()
    {

    }

    
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * projectileSpeed);
    }
}
