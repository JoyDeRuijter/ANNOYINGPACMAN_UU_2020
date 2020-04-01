using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score;
    private int scoreCount = 100;

    public void ScorePellet()
    {
        score += 10;
        scoreText.text = score.ToString();
        CheckScore();
    }

    public void ScorePowerPellet()
    {
        score += 50;
        scoreText.text = score.ToString();
        CheckScore();
    }

    public void ScoreGhost()
    {
        score += 100;
        scoreText.text = score.ToString();
        CheckScore();
    }

//A method created to spawn an advertisement everytime the player earns a 100 points, by using a scoreCount int and calling the SpawnAdvert method.
    public void CheckScore()
    {
        if (score >= scoreCount)
        {
            FindObjectOfType<AdvertSpawner>().SpawnAdvert();
            scoreCount += 100;
        }
    }
}
