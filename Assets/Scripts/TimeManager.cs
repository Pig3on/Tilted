using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayingScene;
using System.Diagnostics;
using System;

public class TimeManager : MonoBehaviour
{
    public UiManager uiManager;
    private Stopwatch stopwatch = new Stopwatch();
    // Start is called before the first frame update
    public void StartCount()
    {
        stopwatch.Start();
    }

    public void StopCount()
    {
        stopwatch.Stop();
    }
    public void Reset()
    {
        stopwatch.Reset();
    }

    // Update is called once per frame
    void Update()
    {
        uiManager.ShowTime(stopwatch.Elapsed.ToString());
    }

    public TimeSpan GetTime()
    {
        return stopwatch.Elapsed;
    }
}
