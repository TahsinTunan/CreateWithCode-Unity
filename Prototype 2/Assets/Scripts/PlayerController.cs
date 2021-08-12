using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    [SerializeField] private float playerSpeed = 10;
    [SerializeField] private float maxLeft = -15, maxRight = 15;

    void Start()
    {
        
    }

    
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
        keepPlayerInBound(maxLeft, maxRight);
    }


    void keepPlayerInBound(float maxLeft, float maxRight)
    {
        if (transform.position.x <= maxLeft)
        {
            transform.position = new Vector3 (maxLeft, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= maxRight)
        {
            transform.position = new Vector3 (maxRight, transform.position.y, transform.position.z);
        }
    }
}
