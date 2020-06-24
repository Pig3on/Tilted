using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MenuScene
{
    public class SettingsManager : MonoBehaviour
    {
        public Slider volumeSlider;
        public Toggle processingToggle;

        public SoundManager soundManager;
        // Start is called before the first frame update

        private void Start()
        {
            float volume = PlayerPrefs.GetFloat(PrefKeys.VOLUME);
            bool useProcessing = PlayerPrefs.GetInt(PrefKeys.USE_PROCESSING) == 1;

            volumeSlider.value = volume;

            soundManager.SetVolumeSound(volume);
            processingToggle.isOn = useProcessing;
        }
        public void onVolumeChange()
        {
            
            //todo chnge volume
            PlayerPrefs.SetFloat(PrefKeys.VOLUME, volumeSlider.value);

            soundManager.SetVolumeSound(volumeSlider.value);

        }

        public void onPostProcessChange()
        {
            PlayerPrefs.SetInt(PrefKeys.USE_PROCESSING,processingToggle.isOn ? 1 : 0);
            //todo set
        }
    }
}
