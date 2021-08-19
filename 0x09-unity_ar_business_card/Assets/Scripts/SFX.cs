using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class SFX : MonoBehaviour
{
    public AudioSource audio;

    public AudioClip sound;

    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void playSound()
    {
        audio.PlayOneShot(sound);
    }
}
