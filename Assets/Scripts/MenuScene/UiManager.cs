using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace MenuScene
{
    public class UiManager : MonoBehaviour
    {
        // Start is called before the first frame update
        public void StartGame() {
            SceneManager.LoadScene("LevelPickerScene");
        }
        public void Settings()
        {
            //todo add settings
        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}