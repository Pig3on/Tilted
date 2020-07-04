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
        public Text tiltLabel;

        public Text tiltScore;
        public Text timerScore;
        public GameObject GameOverPanel;
        public GameObject nextLevelButton;

        public Text timer;

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
            label.text = "Quite Unfortunate";
            GameOverPanel.SetActive(true);
        }

        public void ShowWinScreen()
        {
            label.text = "Splendid";
            tiltScore.gameObject.SetActive(true);
            timerScore.gameObject.SetActive(true);
            nextLevelButton.SetActive(true);
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

        public void ShowTime(string time)
        {
            timer.text = time;
            timerScore.text = "Finished in: " + time;
        }

        public void UpdateTiltNumber(int tilts)
        {
            this.tiltLabel.text = "Number of Tilts: " + tilts;
            tiltScore.text = "With " + tilts + " Tilts";
        }
    }
}

