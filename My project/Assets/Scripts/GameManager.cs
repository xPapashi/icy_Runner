using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score;
    public static GameManager inst;
    public TextMeshProUGUI scoreText;

    public void IncrementScore() {
        score++;
        scoreText.text = "Score: " + score;
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
