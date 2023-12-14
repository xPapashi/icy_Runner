using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //Variables
    public float Speed = 3;
    public float SpeedMultiplier = 0.1f;
    [SerializeField] Rigidbody rb;

    bool isDead = false;

    float horizontalInput;
    [SerializeField] float horizontalMultiplier = 2;

    private void FixedUpdate()
    {
        //Preventing player from moving if dead
        if (isDead) return;
        MovePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();

        if (transform.position.y < -5)
        {
            UnAlive();
        }
    }

    void MovePlayer()
    {
        //Define how player will move forward
        Vector3 forwardMove = transform.forward * Speed * Time.fixedDeltaTime;

        //Define how player will move from left to right
        float moveInput = horizontalInput * Speed * Time.fixedDeltaTime * horizontalMultiplier;
        Vector3 horizontalMove = transform.right * moveInput;

        //Make player constantly move forward by applying values to the rigidbody position
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }

    void GetInput()
    {
        //Check for horizontal input from player
        horizontalInput = Input.GetAxis("Horizontal");
    }

    public void UnAlive()
    {
        //Set player to dead
        isDead = true;

        //Restart game and load new scene
        Invoke("GameRestart", 2);
    }

    void GameRestart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}