﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public static GameController Instance;
    public float scrollSpeed = -1.5f;
    public bool isGameOver = false;
    public int score = 0;

    public Text scoreText;

    public GameObject gameOverText;

    
    void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        } else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        if(isGameOver && Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

  public  void Score()
    {
        if(isGameOver)
        {
            return;
        }
        score++;
        scoreText.text = "Wynik " + score;
    }

   public void Die()
    {
        isGameOver = true;
        gameOverText.SetActive(true);
    }
        
}
