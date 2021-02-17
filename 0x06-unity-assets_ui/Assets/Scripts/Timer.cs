using UnityEngine;
using UnityEngine.UI;
using System;
using System.Diagnostics;

/// <summary> Class Timer, handles time </summary>
public class Timer : MonoBehaviour
{
    /// <summary> UI Text </summary>
    public Text timeText;

    public Text winText;
    /// <summary> Time in float </summary>
    public float timer;
    int MinuteCount;
    int SecondCount;
    float MilliCount;

    void Start()
    {
        timer = 0.0f;
    }
    
    // Update is called once per frame
    void Update()
    {
        timer += 1 * Time.deltaTime;
        MinuteCount = (int)timer/ 60;
        SecondCount = (int)timer% 60;
        MilliCount += Time.deltaTime * 100;
        if (MilliCount >= 100)
        {
            MilliCount = 0;
        }
    
        timeText.text = string.Format("{0:0}:{1:00}.{2:00}", MinuteCount, SecondCount, MilliCount);
        Win();
    }

    public void Win()
    {
        winText.text = timeText.text;
    }
}