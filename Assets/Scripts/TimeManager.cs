using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayingScene;
using System.Diagnostics;
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

    // Update is called once per frame
    void Update()
    {
        uiManager.ShowTime(stopwatch.Elapsed.ToString());
    }
}
