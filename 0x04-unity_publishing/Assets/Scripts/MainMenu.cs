using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button playButton;
    public Button optionsButton;
    public Button quitButton;
    private Scene scene;

    public Material trapMat;
    public Material goalMat;
    public Toggle colorblindMode;


    public void PlayMaze() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        if (colorblindMode.isOn)
        {
            goalMat.color = Color.blue;
            trapMat.color = new Color32(255, 112, 0, 1);
        }
    }

    public void QuitMaze() {
        Debug.Log("Quit Game");
        Application.Quit();
    }
}
