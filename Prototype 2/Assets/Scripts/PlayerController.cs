using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float playerSpeed = 10;
    [SerializeField] private float xRange = 15;

    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
        keepPlayerInBound(-xRange, xRange);
    }


    void keepPlayerInBound(float xLeftRange, float xRightRange)
    {
        if (transform.position.x <= xLeftRange)
        {
            transform.position = new Vector3 (xLeftRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= xRightRange)
        {
            transform.position = new Vector3 (xRightRange, transform.position.y, transform.position.z);
        }
    }
}
