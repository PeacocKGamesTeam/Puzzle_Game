using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System;

[Serializable]
public class GameData
{

    private bool[] animalsPairLevels; //show which level is unlocked
    private bool[] birdsPairLevels; //show which level is unlocked


    private int[] animalsPairLevelStars; //how many stars we have unlocked for the given level
    private int[] birdsPairLevelStars; //how many stars we have unlocked for the given level

    private bool isGameStartedForTheFirstTime; //to know if we will initialize the variables or we store the data

    private float musicVolume;//store the volume of music

    public void SetAnimalsPairLevels(bool[] animalsPairLevels)
    {
        this.animalsPairLevels = animalsPairLevels;
    }

    public bool[] GetAnimalsPairLevels()
    {
        return this.animalsPairLevels;
    }

    public void SetBirdsPairLevels(bool[] birdsPairLevels)
    {
        this.birdsPairLevels = birdsPairLevels;
    }

    public bool[] GetBirdsPairLevels()
    {
        return this.birdsPairLevels;
    }

    public void SetAnimalsPairLevelStars(int[] animalsPairLevelStars)
    {
        this.animalsPairLevelStars = animalsPairLevelStars;
    }

    public int[] GetAnimalsPairLevelStars()
    {
        return this.animalsPairLevelStars;
    }

    public void SetBirdsPairLevelStars(int[] birdsPairLevelStars)
    {
        this.birdsPairLevelStars = birdsPairLevelStars;
    }

    public int[] GetBirdsPairLevelStars()
    {
        return this.birdsPairLevelStars;
    }


    public void SetIsGameStartedForTheFirstTime(bool isGameStartedForTheFirstTime)
    {
        this.isGameStartedForTheFirstTime = isGameStartedForTheFirstTime;
    }

    public bool GetIsGameStartedForTheFirstTime()
    {
        return this.isGameStartedForTheFirstTime;
    }


    public void SetMusicVolume(float musicVolume)
    {
        this.musicVolume = musicVolume;
    }

    public float GetMusicVolume()
    {
        return this.musicVolume;
    }
}
