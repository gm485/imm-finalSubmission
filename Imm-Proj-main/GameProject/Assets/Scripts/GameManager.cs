using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Runtime.CompilerServices;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //gui elements
    public TextMeshProUGUI scoreText;
    private SpawnManager spawnManager;
    private int score = 0;
    public TextMeshProUGUI gameOverText;
    public TextMeshProUGUI WinnerText;
    //check for game active
    public bool isGameActive;
    //access for player movement which detects collisions
    private PlayerMovementX playerMovementX;
    //restart button
    public Button restartButton;
    //title screen controller 
    public GameObject titleScreen;

    // Start is called before the first frame update
    void Start()
    {
        isGameActive = false;
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        playerMovementX = GameObject.Find("Player").GetComponent<PlayerMovementX>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateScore(0);
             
    }
    //update score text
    public void UpdateScore(int scoreToAdd)
    {
        score += scoreToAdd;
        scoreText.text = "Score: " + score;
    }

    //game over gui display
    public void GameOver()
    {
        isGameActive = false;
        gameOverText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
    }

    public void WinGame()
    {
        isGameActive = false;
        WinnerText.gameObject.SetActive(true);
        restartButton.gameObject.SetActive(true);
        gameOverText.gameObject.SetActive(false);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    //start the game 
    public void StartGame()
    {
        isGameActive = true;
        score = 0;
        UpdateScore(0);
        spawnManager.SpawnObstacles();
        titleScreen.gameObject.SetActive(false);
    }

    public void LinkGit()
    {
        Application.OpenURL("https://github.com/gm485/IMM_Project");
    }
    
}
