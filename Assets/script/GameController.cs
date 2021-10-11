using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public GameObject controlPanel;
    public GameObject mainMenuPanel;
    public GameObject startGame;
    public GameObject scoreText;

    private void Start()
    {
        mainMenuPanel.SetActive(true);
        controlPanel.SetActive(false);
        gamePause();
        startGame.SetActive(true);
    }

    private void Update()
    {
       
    }
    public void GameOver()
    {
        scoreText.SetActive(false);
        controlPanel.SetActive(true);

    }
    public void Restart()
    {
        scoreText.SetActive(false);
        SceneManager.LoadScene("myGame");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    public void Play()
    {
        mainMenuPanel.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void gamePause()
    {
        Time.timeScale = 0f;
    }

    public void gameStart()
    {
        startGame.SetActive(false);
        scoreText.SetActive(true);
        Time.timeScale = 1f;
    }
}
