using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverPanel;  // Assign your Game Over panel here in the Inspector

    private bool isGameOver = false;

    void Start()
    {
        gameOverPanel.SetActive(false); 
    }

    public void GameOver()
    {
        if (isGameOver) return;

        isGameOver = true;
        gameOverPanel.SetActive(true);  
        Time.timeScale = 0f;

        FindObjectOfType<ScoreManager>().ResetHighScore();


    }

    public void ReplayGame()
    {
        Time.timeScale = 1f;
        FindObjectOfType<ScoreManager>().ResetHighScore();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ExitGame()
    {
        Application.Quit();  
        Debug.Log("Game is exiting");  
    }



}
