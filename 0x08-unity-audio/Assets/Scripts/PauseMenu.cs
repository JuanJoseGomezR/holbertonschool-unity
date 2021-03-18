using System;
using System.ComponentModel;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public Canvas PauseCanvas;

    public AudioSource bgm;

    public bool PausedGame;
    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("escape");

            if (PausedGame)
            {
                Resume();
            }
            else
            {
                Pause();

            }
        }
    }
    public void Pause()
    {

        PauseCanvas.gameObject.SetActive(true);
        Time.timeScale = 0f;
        PausedGame = true;
        bgm.Stop();
    }

    public void Resume()
    {
        PauseCanvas.gameObject.SetActive(false);
        Time.timeScale = 1f;
        PausedGame = false;
        bgm.Play();
    }
    public void Restart()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Options()
    {
        Time.timeScale = 1f;
        PlayerPrefs.SetString("lastScene", SceneManager.GetActiveScene().name);
        SceneManager.LoadScene("Options");
    }
}
