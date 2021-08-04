using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15.0f;
    public float turnSpeed = 0.25f;
    private float turnInput;

    // Start is called before the first frame update
    void Start()
    {
        turnInput = Input.GetAxis("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        // Turn
        turnInput = Input.GetAxis("Horizontal");
        turn(turnSpeed);
    }



    // Movement Functions
    private void turn (float turnSpeed)
    {
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * turnSpeed * turnInput);
    }

}
