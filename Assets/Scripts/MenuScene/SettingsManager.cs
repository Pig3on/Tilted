using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace MenuScene
{
    public class SettingsManager : MonoBehaviour
    {
        public Slider volumeSlider;
        public Slider SFXSlider;
        public Toggle processingToggle;

        public SoundManager soundManager;
        // Start is called before the first frame update

        private void Start()
        {
            float volume = PlayerPrefs.GetFloat(PrefKeys.VOLUME);
            float sfxVolume = PlayerPrefs.GetFloat(PrefKeys.SFX_VALUE);
            bool useProcessing = PlayerPrefs.GetInt(PrefKeys.USE_PROCESSING) == 1;

            volumeSlider.value = volume;

            soundManager.SetVolumeSound(volume);
            soundManager.SetSFXSound(sfxVolume);
            processingToggle.isOn = useProcessing;
        }
        public void onVolumeChange()
        {
            
            //todo chnge volume
            PlayerPrefs.SetFloat(PrefKeys.VOLUME, volumeSlider.value);

            soundManager.SetVolumeSound(volumeSlider.value);

        }

        public void onSFXChange()
        {

            //todo chnge volume
            PlayerPrefs.SetFloat(PrefKeys.SFX_VALUE, SFXSlider.value);

            soundManager.SetSFXSound(SFXSlider.value);
            soundManager.PlayClip(Clips.AWW);

        }

        public void onPostProcessChange()
        {
            PlayerPrefs.SetInt(PrefKeys.USE_PROCESSING,processingToggle.isOn ? 1 : 0);
            //todo set
        }
    }
}
