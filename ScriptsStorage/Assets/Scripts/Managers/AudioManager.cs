using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public AudioMixer _MasterMixer;
    public static AudioManager audioMan;
    [SerializeField] AudioSource audSource;
    private void Awake()
    {
        
        if (audioMan == null)
        {
            audioMan = this;
            DontDestroyOnLoad(this);
        }
        else if (audioMan != this)
        {
            Destroy(gameObject);
        }

        audSource = GetComponent<AudioSource>();
    }

    public void playSound(AudioClip clipName)
    {
        audSource.PlayOneShot(clipName);
    }
    

    public void SetMasterVolume(Slider volume)
    {
        _MasterMixer.SetFloat("Master", volume.value);
        PlayerPrefs.SetFloat("MasterVol", volume.value);
    }

    public void SetMusicVolume(Slider volume)
    {
        _MasterMixer.SetFloat("Music", volume.value);
        PlayerPrefs.SetFloat("MusicVol", volume.value);
    }

    public void SetSFXVolume(Slider volume)
    {
        _MasterMixer.SetFloat("SFX", volume.value);
        PlayerPrefs.SetFloat("SFXVol", volume.value);
    }

}

