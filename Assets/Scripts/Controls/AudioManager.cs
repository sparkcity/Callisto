using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    private static AudioManager instance = null;
    //public static AudioSource audioSource;
    public AudioMixer audioMixer;
    public float audioVolume;

    public static AudioManager Instance
    {
        get { return instance; }
    }

    void Awake()
    {
        if (instance != null && instance != this)
        {
            if (instance.GetComponent<AudioSource>().clip != GetComponent<AudioSource>().clip)
            {
                instance.GetComponent<AudioSource>().clip = GetComponent<AudioSource>().clip;
                instance.GetComponent<AudioSource>().volume = GetComponent<AudioSource>().volume;
                instance.GetComponent<AudioSource>().Play();
            }

            Destroy(this.gameObject);
            return;
        }
        instance = this;
        GetComponent<AudioSource>().Play();
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        audioMixer.SetFloat("MasterVolume", PlayerPrefs.GetFloat("savedAudioPref"));
    }


    public void SetVolume(float volume)
    {
        audioVolume = volume;
        audioMixer.SetFloat("MasterVolume", volume);
        PlayerPrefs.SetFloat("savedAudioPref", volume);
    }

    public void playMusic()
    {
        instance.GetComponent<AudioSource>().Play();
    }

    public void stopMusic()
    {
        instance.GetComponent<AudioSource>().Stop();
    }

    public void changeSource(AudioSource newSource)
    {
        instance.GetComponent<AudioSource>().clip = GetComponent<AudioSource>().clip;
    }

}
