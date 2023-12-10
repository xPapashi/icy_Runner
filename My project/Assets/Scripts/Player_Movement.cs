using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    //Variables
    public float Speed = 3;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalMultiplier = 2;

    private void FixedUpdate()
    {
        MovePlayer();
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
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
}