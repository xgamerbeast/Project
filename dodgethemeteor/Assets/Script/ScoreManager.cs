using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI highScoreText;

    private float score = 0f;
    private int highScore = 0;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        UpdateScoreUI();
    }

    void Update()
    {
        score += Time.deltaTime * 2;
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();

        if (Mathf.FloorToInt(score) > highScore)
        {
            highScore = Mathf.FloorToInt(score);
            PlayerPrefs.SetInt("HighScore", highScore);
            UpdateScoreUI();
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        highScoreText.text = "High Score: " + highScore.ToString();
    }

    public void ResetHighScore()
    {
        PlayerPrefs.SetInt("HighScore", 0);
        highScore = 0; 
        UpdateScoreUI(); 
        Debug.Log("High Score has been reset in ScoreManager.");
    }

}
