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

        public Text title;

        // Start is called before the first frame update
        void Start()
        {
            title.text = "Level: " + (LevelPickerData.CurrentPickedLevel + 1);
            LevelManager.SpawnLevel(LevelPickerData.CurrentPickedLevel, true);
        }

        public void StartLevel()
        {
            SceneManager.LoadScene(Scenes.PLAYING_SCENE);
        }


        public void NextLevelPress()
        {
            if (LevelPickerData.CurrentPickedLevel + 1 >= LevelManager.GetTotalLevels())
            {
                return;
            }
            LevelPickerData.CurrentPickedLevel += 1;
            title.text = "Level: " + (LevelPickerData.CurrentPickedLevel + 1);
            LevelManager.RemoveCurrentLevel();
            LevelManager.SpawnLevel(LevelPickerData.CurrentPickedLevel, true);
        }

        public void PrevLevelPress()
        {
            if (LevelPickerData.CurrentPickedLevel - 1 < 0)
            {
                return;
            }
            LevelPickerData.CurrentPickedLevel -= 1;
            title.text = "Level: " + (LevelPickerData.CurrentPickedLevel + 1);
            LevelManager.RemoveCurrentLevel();
            LevelManager.SpawnLevel(LevelPickerData.CurrentPickedLevel, true);
        }
        public void OnBackPress()
        {
            SceneManager.LoadScene(Scenes.MAIN_MENU);
        }
    }
}