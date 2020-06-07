using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
namespace PlayingScene
{
    public class UiManager : MonoBehaviour
    {
        public Text label;
        public GameObject GameOverPanel;

        public void OnRestartScene()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(Scenes.PLAYING_SCENE);
        }
        public void OnExitPress()
        {
            Time.timeScale = 1;
            SceneManager.LoadScene(Scenes.LEVEL_PICKER_SCENE);
        }

        public void ShowGameOver()
        {
            label.text = "Oh no!";
            GameOverPanel.SetActive(true);
        }

        public void ShowWinScreen()
        {
            label.text = "You win";
            GameOverPanel.SetActive(true);
        }

        public void ShowPause()
        {
            label.text = "Paused";
            GameOverPanel.SetActive(true);
        }
        public void HidePause()
        {
            GameOverPanel.SetActive(false);
        }

    }
}

