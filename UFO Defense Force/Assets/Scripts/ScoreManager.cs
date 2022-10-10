using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score; // Store score value
    public TextMeshProUGUI scoreText; // Reference visual text UI element to change


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // This function rewards the player 
    public void IncreaseScore(int amount)
    {
        score += amount; //add amount to score
        UpdateScoreText(); //Update the score UI text
    }
    //This function penalizes the player
    public void DecreaseScore(int amount)
    {
        score -= amount; //Subtract amount from the score
        UpdateScoreText(); //Update the score UI text
    }

    public void UpdateScoreText()
    {
        scoreText.text = "Score: "+ score;
    }


}
