using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using PlayingScene;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public LevelManager LevelManager;
    public CameraManager cameraManager;
    public SoundManager SoundManager;
    public UiManager UiManager;
    public TiltsCounter tiltsCounter;
    public TimeManager TimeManager;
    private SaveManager SaveManager;
    public bool levelDone;
    public bool isPaused = false;
    private void Awake()
    {
        Debug.Log("spawning");
        int pickedLevel = LevelPickerData.GetCurrentLevel();

        Debug.Log(pickedLevel);

        LevelManager.SpawnLevel(pickedLevel);

        this.SoundManager = GameObject.FindGameObjectWithTag(Tags.SOUND_MANAGER)?.GetComponent<SoundManager>();
        this.SaveManager = GameObject.FindGameObjectWithTag(Tags.STORAGE_MANAGER)?.GetComponent<SaveManager>();
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
            SoundManager.PlayClip(Clips.CLAP);

            LevelScore score = new LevelScore();

            score.NumberOfTilts = tiltsCounter.tilts;
            score.TimeInSeconds = TimeManager.GetTime().TotalSeconds;
            SaveManager.SaveScore(LevelPickerData.GetCurrentLevel(), score);
        }
       
    }
    public void LevelFailed()
    {
        if(!levelDone)
        {
            levelDone = true;
            cameraManager.SwitchToPlayerView();
            UiManager.ShowGameOver();
            SoundManager.PlayClip(Clips.AWW);
        }
    
    }

    public void LoadNextLevel()
    {
        try
        {
            LevelPickerData.GetNextLevel();
            SceneManager.LoadScene(Scenes.PLAYING_SCENE);
        }catch (Exception)
        {
            SceneManager.LoadScene(Scenes.LEVEL_PICKER_SCENE);
        }
       
    }
}
