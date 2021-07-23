using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hoverSFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip buttonRollover;
    public AudioClip buttonClick;

    public void OnButtonHover()
    {
        myFx.PlayOneShot(buttonRollover);
    }

    public void OnButtonClick()
    {
        myFx.PlayOneShot(buttonClick);
    }
}
