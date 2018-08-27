using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //public UIText scoreText;
    public Text scoreText;
    private int score;

    void Start()
    {
        scoreText = GetComponent<Text>();
        score = 0;
        UpdateScore();
        
    }

    public void AddScore(int newScoreValue)
    {
        score += newScoreValue;
        UpdateScore();
    }

    public void UpdateScore()
    {
        scoreText.text = "Score: " + score;
    }
}