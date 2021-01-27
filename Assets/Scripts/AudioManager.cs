using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour
{
    public Sound[] sounds;

    public static AudioManager instance;
    public AudioMixer audioMixer;

    void Awake()
    {
        // only want one audio manager
        if (instance == null)
        {
            instance = this;
        } else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }

    void Start()
    {
        Play("Theme");
    }

    public void Play(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        // check if sound exists
        if (s == null)
        {
            Debug.LogWarning("Sound: " + name + " not found!");
            return;
        }

        s.source.Play();
    }

    public void SetVolume(float volume)
    {
        //audioMixer.SetFloat("volume", volume);
        audioMixer.SetFloat("volume", Mathf.Log10(volume) * 20);
    }

}
