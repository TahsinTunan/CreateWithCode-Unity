using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRB;
    private Animator playerAnim;
    private bool isGrounded = true;
    private bool gameOver = false;
    private AudioSource playerAudio;
    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private AudioClip crashSound;
    [SerializeField] private float sfxVol = 1f;
    [SerializeField] private ParticleSystem explosionParticle;
    [SerializeField] private ParticleSystem dirtParticle;
    [SerializeField] private string gameOverText = "Game over!";
    [SerializeField] private float jumpForce = 10;
    [SerializeField] private float gravityMultiplier = 1;


    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity *= gravityMultiplier;
        playerAnim = GetComponent<Animator>();

        playerAudio = GetComponent<AudioSource>();
    }


    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) && isGrounded && !gameOver)
        {
            jump(playerRB, jumpForce);
        }
    }

    private void jump(Rigidbody playerRigidBody, float jumpForce)
    {
        playerRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        isGrounded = false;
        dirtParticle.Stop();
        playerAudio.PlayOneShot(jumpSound, sfxVol);
        playerAnim.SetTrigger("Jump_trig");
    }

    private void GameOver()
    {
        gameOver = true;
        playerAnim.SetBool("Death_b", true);
        playerAnim.SetInteger("DeathType_int", 1);
        explosionParticle.Play();
        playerAudio.PlayOneShot(crashSound, sfxVol);
        dirtParticle.Stop();

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
            dirtParticle.Play();
        }
        else if (other.gameObject.CompareTag("Obstacle"))
        {
            GameOver();
        }
    }
}
