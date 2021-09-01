using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] private float speed = 10;
    private PlayerController playerControllerScript;
    [SerializeField] private float leftBound = -9;

    void Start()
    {
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (playerControllerScript.getGameOver() == false){
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }

        if ( (transform.position.x <= leftBound) && (gameObject.CompareTag("Obstacle")) )
        {
            Destroy(gameObject);
        }
    }
}
