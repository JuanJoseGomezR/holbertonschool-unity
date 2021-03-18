using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class BGMSlider : MonoBehaviour
{
    private static readonly string FirstPlay = "FirstPlay";
    private static readonly string sfxPref = "sfxPref";
    private static readonly string backgroundPref = "backgroundPref";
    private int firstPlayInt;

    public Slider sfxSlider;
    public Slider backgroundSlider;
    private float sfxFloat;
    private float backgroundFloat;
    public AudioSource[] sfxAudio;
    public AudioSource backgroundAudio;

    void Start()
    {
        firstPlayInt = PlayerPrefs.GetInt(FirstPlay);

        if (firstPlayInt == 0)
        {
            backgroundFloat = .125f;
            sfxFloat = .75f;
            backgroundSlider.value = backgroundFloat;
            sfxSlider.value = sfxFloat;
            PlayerPrefs.SetFloat(backgroundPref, backgroundFloat);
            PlayerPrefs.SetFloat(sfxPref, sfxFloat);
            PlayerPrefs.SetInt(FirstPlay, -1);
        }
        else
        {
            backgroundFloat = PlayerPrefs.GetFloat(backgroundPref);
            backgroundSlider.value = backgroundFloat;
            sfxFloat = PlayerPrefs.GetFloat(sfxPref);
            sfxSlider.value = sfxFloat;
        }
    }

    public void SaveSoundSetting()
    {
        PlayerPrefs.SetFloat(backgroundPref, backgroundSlider.value);
        PlayerPrefs.SetFloat(sfxPref, sfxSlider.value);
    }
    void OnApplicationFocus(bool inFocus)
    {
        if (!inFocus)
        {
            SaveSoundSetting();
        }
    }

    public void UpdateSound()
    {
        backgroundAudio.volume = backgroundSlider.value;

        for (int i = 0; i < sfxAudio.Length; i++)
        {
            sfxAudio[i].volume = sfxSlider.value;
        }
    }
}
