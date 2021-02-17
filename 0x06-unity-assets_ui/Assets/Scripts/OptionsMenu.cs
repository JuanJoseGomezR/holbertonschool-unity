using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OptionsMenu : MonoBehaviour
{
    public Button BackButton;

    public Toggle invertAxis;

    void Start()
    {
        if (PlayerPrefs.GetInt("isInverted") == 1)
            invertAxis.isOn = true;
        else
            invertAxis.isOn = false;
    }
    public void Back()
    {
        SceneManager.LoadScene(PlayerPrefs.GetString("lastScene"));
    }

    public void Apply()
    {
        if (invertAxis.isOn)
            PlayerPrefs.SetInt("isInverted", 1);
        else
            PlayerPrefs.SetInt("isInverted", 0);
        
        Back();
    }

}
