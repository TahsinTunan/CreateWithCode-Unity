using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Animator playerAnim;
    private bool isGrounded = true;
    private bool gameOver = false;
    [SerializeField] private string gameOverText = "Game over!";
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float gravityMultiplier = 1;


    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMultiplier;
        playerAnim = GetComponent<Animator>();
    }


    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) && isGrounded)
        {
            jump(playerRB, jumpForce);
        }
    }

    private void jump(Rigidbody playerRigidBody, float jumpForce)
    {
        playerRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        playerAnim.SetTrigger("Jump_trig");
    }

    private void GameOver()
    {
        gameOver = true;
        playerAnim.SetBool("Death_b", true);
        playerAnim.SetInteger("DeathType_int", 1);

        Debug.Log(gameOverText);
    }

    public bool getGameOver()
    {
        return gameOver;
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            GameOver();
        }
    }
}
