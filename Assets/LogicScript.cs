using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score;
    public Text scoreText;
    public GameObject gameOverScreen;
    public GameObject bird;
    public GameObject pipeSpawner;
    public GameObject cloudSpawner;
    public GameObject smilingCloudSpawner;
    public GameObject startScreen;
    public Text txt;

    [ContextMenu("Increase Score")]
    public void addScore(int toAdd)
    {
        score = score + toAdd;
        scoreText.text = score.ToString();
    }

    public void startGame()
    {
        bird.SetActive(true);
        pipeSpawner.SetActive(true);
        cloudSpawner.SetActive(true);
        smilingCloudSpawner.SetActive(true);
        startScreen.SetActive(false);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        Invoke("restartGame", 4);
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
