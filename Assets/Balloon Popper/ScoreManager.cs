using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int Score;
    public TextMeshProUGUI ScoreText;

    private void Start()
    {
        UpdateScoreText();
    }

    public void IncreaseScore(int amount)
    {
        Score += amount;
        UpdateScoreText();
    }

    public void UpdateScoreText()
    {
        ScoreText.text = "Score: " + Score;
    }
}
