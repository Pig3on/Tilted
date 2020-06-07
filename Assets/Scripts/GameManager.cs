using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using PlayingScene;
public class GameManager : MonoBehaviour
{
    public LevelManager LevelManager;
    public CameraManager cameraManager;
    public UiManager UiManager;
    public bool levelDone;
    public bool isPaused = false;
    private void Awake()
    {
        Debug.Log("spawning");
        int pickedLevel = LevelPickerData.CurrentPickedLevel;

        Debug.Log(pickedLevel);

        LevelManager.SpawnLevel(pickedLevel);
    }


    private void Update()
    {
        if (Input.GetButtonDown(Buttons.PAUSE) && !levelDone)
        {
            if (isPaused)
            {
                Time.timeScale = 1;
                isPaused = false;
                UiManager.HidePause();
            }
            else
            {
                Time.timeScale = 0;
                isPaused = true;
                UiManager.ShowPause();
            }
           
        }
    }

    public void LevelFinished()
    {
        if (!levelDone)
        {
            levelDone = true;
            cameraManager.SwitchToPlayerView();
            UiManager.ShowWinScreen();
        }
       
    }
    public void LevelFailed()
    {
        if(!levelDone)
        {
            levelDone = true;
            cameraManager.SwitchToPlayerView();
            UiManager.ShowGameOver();
        }
    
    }
}
