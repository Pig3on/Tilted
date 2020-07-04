using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace LevelPickerScene
{
    public class UiManager : MonoBehaviour
    {
        // Start is called before the first frame update
        public LevelManager LevelManager;

        private SaveManager SaveManager;

        public Text title;
        public Text finished;
        public Text tiltCount;
        public Text time;

        // Start is called before the first frame update
        void Start()
        {
            title.text = "Level: " + (LevelPickerData.GetCurrentLevel() + 1);
            LevelManager.SpawnLevel(LevelPickerData.GetCurrentLevel(), true);
            SaveManager = GameObject.FindGameObjectWithTag(Tags.STORAGE_MANAGER)?.GetComponent<SaveManager>();
            this.CheckScore();

            LevelPickerData.SetMaxLevels(LevelManager.GetTotalLevels());
        }

        public void StartLevel()
        {
            SceneManager.LoadScene(Scenes.PLAYING_SCENE);
        }


        public void NextLevelPress()
        {
            if (LevelPickerData.GetCurrentLevel() + 1 >= LevelManager.GetTotalLevels())
            {
                return;
            }
           
            try
            {
                LevelPickerData.GetNextLevel();
            }
            catch (Exception)
            {
                //nothing
            }
            title.text = "Level: " + (LevelPickerData.GetCurrentLevel() + 1);
            LevelManager.RemoveCurrentLevel();
            LevelManager.SpawnLevel(LevelPickerData.GetCurrentLevel(), true);
            this.CheckScore();
          }

        private void CheckScore()
        {
            LevelScore score;
            SaveManager.GetScore().TryGetValue(LevelPickerData.GetCurrentLevel(), out score);
            if (score == null)
            {
                finished.text = "Not Completed";
                tiltCount.gameObject.SetActive(false);
                time.gameObject.SetActive(false);
            }
            else
            {
                finished.text = "Completed";
                tiltCount.text = score.NumberOfTilts + " tilts";
                time.text = score.TimeInSeconds + " seconds";
                tiltCount.gameObject.SetActive(true);
                time.gameObject.SetActive(true);
            }
        }

        public void PrevLevelPress()
        {
            if (LevelPickerData.GetCurrentLevel() - 1 < 0)
            {
                return;
            }
            try
            {
                LevelPickerData.GetPreviousLevel();
            }
            catch (Exception)
            {
                //nothing
            }
            title.text = "Level: " + (LevelPickerData.GetCurrentLevel() + 1);
            LevelManager.RemoveCurrentLevel();
            LevelManager.SpawnLevel(LevelPickerData.GetCurrentLevel(), true);
            this.CheckScore();
        }
        public void OnBackPress()
        {
            SceneManager.LoadScene(Scenes.MAIN_MENU);
        }
    }
}