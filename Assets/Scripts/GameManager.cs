using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.UI;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI scoreText;
    public int multiplier = 43;
    private int multipliedScore = 0;
    private int highScore = 0;

    //show score in PauseMenu and GameOver
    public TextMeshProUGUI pauseMenuScore;
    public TextMeshProUGUI gameOverScore;

    public bool isDead = false;

    // Update is called once per frame
    void Update()
    {
        multipliedScore = (score * multiplier);

        scoreText.text = multipliedScore.ToString("0");
        pauseMenuScore.text = multipliedScore.ToString("0");
        gameOverScore.text = multipliedScore.ToString("0");

        //setting high score
        highScore = PlayerPrefs.GetInt("HighScore", 0);

        if(multipliedScore > highScore)
        {
            PlayerPrefs.SetInt("HighScore", multipliedScore);
            highScore = PlayerPrefs.GetInt("HighScore", 0);
        }

        Debug.Log(highScore);
    }

    public void IncrementScore(int amount)
    {
        score += amount;
        Debug.Log("Score: " + score);
        Debug.Log("Health: " + HealthManager.health);
    }
}
