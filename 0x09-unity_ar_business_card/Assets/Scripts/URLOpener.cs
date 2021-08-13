using System.Net.Mime;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URLOpener : MonoBehaviour
{
    public string Url;

    public void Open()
    {
        Application.OpenURL(Url);
    }
}
