﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    private bool pausedGame = false;
    [SerializeField] private GameObject pauseMenuUI;

    public GameObject PauseMenuUI
    {
        get => pauseMenuUI;
        set => pauseMenuUI = value;
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausedGame)
            {
                ContinuePlaying();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void LoadPlayScene()
    {
        SceneManager.LoadScene("SceneMarvin");
        Time.timeScale = 1f;
    }


    public void ContinuePlaying()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        pausedGame = false;
    }

    public void PauseGame()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        pausedGame = true;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("SceneMenu");
    }

    public void Quit()
    {
        Application.Quit();
    }
}