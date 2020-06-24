using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    private static AudioClip music, aww, clap;

    private AudioSource AudioSourceSoundtrack;

    private AudioSource AudioSourceEffect;
    public static SoundManager Instance;

    // Start is called before the first frame update
    private void Awake()
    {
        if (!Instance)
        {
            music = Resources.Load<AudioClip>("Sounds/OST");
            aww = Resources.Load<AudioClip>("Sounds/Aww");
            clap = Resources.Load<AudioClip>("Sounds/Clap");
            AudioSource[] sources = GetComponents<AudioSource>();


            AudioSourceSoundtrack = sources[0];
            AudioSourceEffect = sources[1];
            float volume = PlayerPrefs.GetFloat(PrefKeys.VOLUME);
            AudioSourceSoundtrack.volume = volume == 0 ? 100: volume;


            Instance = this;
            DontDestroyOnLoad(gameObject);
            AudioSourceSoundtrack.PlayOneShot(music);
        }
        else
        {
            Destroy(this.gameObject);
        }


    }
    public void PlayClip(Clips clip)
    {
        switch (clip)
        {
            case Clips.AWW:
                AudioSourceEffect.PlayOneShot(aww);
                break;
            case Clips.CLAP:
                AudioSourceEffect.PlayOneShot(clap);
                break;
            default:
                AudioSourceEffect.PlayOneShot(clap);
                break;
        }
    }
    public void SetVolumeSound(float volume)
    {
        AudioSourceSoundtrack.volume = volume;
    }

    public void SetSFXSound(float volume)
    {
        AudioSourceEffect.volume = volume;
    }
}
