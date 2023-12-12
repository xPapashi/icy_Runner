using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    Player_Movement playerMovement;

    // Start is called before the first frame update
    void Start()
    {
        //Looking for object that has playerMovement type
        playerMovement = GameObject.FindObjectOfType<Player_Movement>(); 
    }

    void OnCollisionEnter (Collision collision) {
        if (collision.gameObject.name == "Player") {
            //Destroy player when colliding with object
            playerMovement.UnAlive();
        }
    }
}
