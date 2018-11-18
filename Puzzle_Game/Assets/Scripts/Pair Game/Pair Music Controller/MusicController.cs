using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicController : MonoBehaviour
{
    [SerializeField] //use for showing a private variable's value on Inspector.
    private PairGameSaver pairGameSaver;

    private AudioSource bgMusicClip;

    private float musicVolume;

    void Awake()
    {
        GetAudioSource();
    }

    void Start()
    {
        musicVolume = pairGameSaver.musicVolume;
        PlayOrTurnOffMusic(musicVolume);
    }

    void GetAudioSource()
    {

        bgMusicClip = GetComponent<AudioSource>();
    }

    public void SetMusicVolume(float volume)
    {
        PlayOrTurnOffMusic(volume);

    }

    void PlayOrTurnOffMusic(float volume)
    {
        musicVolume = volume;

        bgMusicClip.volume = musicVolume;

        //play music
        if(bgMusicClip.volume > 0)
        {
            //if the audio source is not playing
            if (!bgMusicClip.isPlaying)
            {
                bgMusicClip.Play();

            }

            pairGameSaver.musicVolume = musicVolume;
            pairGameSaver.SaveGameData();
        }
        else if (bgMusicClip.volume == 0)
        {

            if (bgMusicClip.isPlaying)
            {
                bgMusicClip.Stop();

            }

            pairGameSaver.musicVolume = musicVolume;
            pairGameSaver.SaveGameData();
        }
    }


    public float GetMusicVolume()
    {
        return this.musicVolume;
    }
}
