using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
namespace MenuScene
{
    public class UiManager : MonoBehaviour
    {
        public GameObject SettingsPanel;
        // Start is called before the first frame update
        public void StartGame() {
            SceneManager.LoadScene(Scenes.LEVEL_PICKER_SCENE);
        }
        public void Settings()
        {
            SettingsPanel.SetActive(true);
        }

        public void CloseSettings()
        {
            SettingsPanel.SetActive(false);
            PlayerPrefs.Save();
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}