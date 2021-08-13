using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    [SerializeField] private float playerSpeed = 10;
    [SerializeField] private float xRange = 15;
    [SerializeField] GameObject projectilePrefab;

    void Start()
    {

    }


    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        movePlayer(playerSpeed);
        keepPlayerInBound(-xRange, xRange);
        shootProjectile(projectilePrefab);
    }


    void keepPlayerInBound(float xLeftRange, float xRightRange)
    {
        if (transform.position.x <= xLeftRange)
        {
            transform.position = new Vector3(xLeftRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x >= xRightRange)
        {
            transform.position = new Vector3(xRightRange, transform.position.y, transform.position.z);
        }
    }

    void shootProjectile(GameObject projectile)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
        }
    }

    void movePlayer(float playerSpeed)
    {
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * playerSpeed);
    }
}
