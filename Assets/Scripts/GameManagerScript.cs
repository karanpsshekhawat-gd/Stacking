using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Important for Button!

public class GameManagerScript : MonoBehaviour
{
    public GameObject gameOverPanel; // Assign the GameOver panel in Inspector

    private bool gameIsOver = false;

    void Start()
    {
        gameOverPanel.SetActive(false); // Hide at start
    }

    public void GameOver()
    {
        if (gameIsOver) return;
        gameIsOver = true;
        gameOverPanel.SetActive(true); // Show Game Over panel
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reloads current scene
    }

    public void QuitGame()
    {
        Application.Quit(); // Quits the game
        Debug.Log("Quit Game"); // Works only after build, not inside Unity Editor
    }
}

