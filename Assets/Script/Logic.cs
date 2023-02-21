using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Logic : MonoBehaviour
{
    [SerializeField] private AudioSource pointSound;
    [SerializeField] private int playerScore;
    [SerializeField] private Text scoreText;
    [SerializeField] private GameObject gameOverScreen;
    [ContextMenu("Increas Score")]
    public void addScore(int scoreToAdd)
    {
        playerScore = playerScore + scoreToAdd;
        scoreText.text = playerScore.ToString();
        pointSound.Play();
    }


    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }


    public void GameOver()
    {
        gameOverScreen.SetActive(true);
    }
}

