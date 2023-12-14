using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    int score;
    public static GameManager inst;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] Player_Movement playerMovement;

    public void IncrementScore() {
        //Increase score
        score++;
        //Update Score Text
        scoreText.text = "Score: " + score;
        //Increase Player Movement
        playerMovement.Speed += playerMovement.SpeedMultiplier;
    }

    void Awake() {
        inst = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
