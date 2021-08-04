using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 70f;
    private float turnInput, accelerateInput;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Accelerate
        accelerateInput = Input.GetAxis("Vertical");
        accelerate(speed);

        // Turn
        turnInput = Input.GetAxis("Horizontal");
        turn(turnSpeed);
    }



    // Movement Functions
    private void accelerate(float speed)
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed * accelerateInput);
    }
    private void turn (float turnSpeed)
    {
        transform.Rotate(new Vector3(0, 1, 0) * Time.deltaTime * turnSpeed * turnInput);
    }

}
