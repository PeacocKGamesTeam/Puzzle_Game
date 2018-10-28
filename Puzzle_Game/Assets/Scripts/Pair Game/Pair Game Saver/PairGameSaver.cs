using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class PairGameSaver : MonoBehaviour
{


    private GameData gameData;

    public bool[] animalsPairLevels; //show which level is unlocked
    public bool[] birdsPairLevels; //show which level is unlocked


    public int[] animalsPairLevelStars; //how many stars we have unlocked for the given level
    public int[] birdsPairLevelStars; //how many stars we have unlocked for the given level

    private bool isGameStartedForTheFirstTime; //to know if we will initialize the variables or we store the data

    public float musicVolume;//store the volume of music

    private void Awake()
    {
        InitializeGame();
    }

    void InitializeGame()
    {

        LoadGameData();

        if(gameData != null)
        {
            isGameStartedForTheFirstTime = gameData.GetIsGameStartedForTheFirstTime();
        }
        else
        {
            isGameStartedForTheFirstTime = true;
        }

        if (isGameStartedForTheFirstTime)
        {
            isGameStartedForTheFirstTime = false;//to not executed the next time

            musicVolume = 0;

            animalsPairLevels = new bool[15];
            birdsPairLevels = new bool[15];

            animalsPairLevels[0] = true; //the first level is unlock
            birdsPairLevels[0] = true; //the first level is unlock

            //the other levels are unlocked
            for (int i = 1; i< animalsPairLevels.Length; i++)
            {
                animalsPairLevels[i] = false;
                birdsPairLevels[i] = false;
            }

            animalsPairLevelStars = new int[15];
            birdsPairLevelStars = new int[15];

            //initialize stars
            for (int i = 0; i < animalsPairLevels.Length; i++)
            {
                animalsPairLevelStars[i] = 0;
                birdsPairLevelStars[i] = 0;
            }


            gameData = new GameData();

            gameData.SetAnimalsPairLevels(animalsPairLevels);
            gameData.SetBirdsPairLevels(birdsPairLevels);

            gameData.SetAnimalsPairLevelStars(animalsPairLevelStars);
            gameData.SetBirdsPairLevelStars(birdsPairLevelStars);

            gameData.SetIsGameStartedForTheFirstTime(isGameStartedForTheFirstTime);
            gameData.SetMusicVolume(musicVolume);


            SaveGameData();
            LoadGameData();
        }




    }

    void SaveGameData()
    {
        FileStream file = null;

        try
        {
            BinaryFormatter bf = new BinaryFormatter(); //BinaryFormatter encrypt data
            file = File.Create(Application.persistentDataPath + "/GameData.dat");

            if (gameData != null)
            {
                gameData.SetAnimalsPairLevels(animalsPairLevels);
                gameData.SetBirdsPairLevels(birdsPairLevels);

                gameData.SetAnimalsPairLevelStars(animalsPairLevelStars);
                gameData.SetBirdsPairLevelStars(birdsPairLevelStars);

                gameData.SetIsGameStartedForTheFirstTime(isGameStartedForTheFirstTime);
                gameData.SetMusicVolume(musicVolume);


                bf.Serialize(file, gameData);//saving gameData to the path "file"
            }

        }
        catch (Exception e)
        {

        }
        finally
        {
            if (file != null)
            {
                file.Close();
            }
        }
    }

    void LoadGameData()
    {
        FileStream file = null;
        try
        {
            BinaryFormatter bf = new BinaryFormatter(); //BinaryFormatter encrypt data

            file = File.Open(Application.persistentDataPath + "/GameData.dat", FileMode.Open);

            gameData = (GameData)bf.Deserialize(file); //decrypt data

            //assign all variables 
            if (gameData != null)
            {
                animalsPairLevels = gameData.GetAnimalsPairLevels();
                birdsPairLevels = gameData.GetBirdsPairLevels();


                animalsPairLevelStars = gameData.GetAnimalsPairLevelStars();
                birdsPairLevelStars = gameData.GetBirdsPairLevelStars();


                musicVolume = gameData.GetMusicVolume(); 
            }

        }
        catch (Exception e)
        {

        }
        finally
        {
            if (file != null)
            {
                file.Close();
            }
        }

    }

    //function to unlock the next level
    public void Save(int level, string selectedPair, int stars)
    {
        int unlockNextLevel = -1;

        switch (selectedPair)
        {
            case "Animals Pair":
                unlockNextLevel = (level-1) + 1;

                animalsPairLevelStars[level-1] = stars;
                if(unlockNextLevel < animalsPairLevels.Length)
                {
                    animalsPairLevels[unlockNextLevel] = true;
                }

                break;


            case "Birds Pair":
                unlockNextLevel = (level - 1) + 1;

                birdsPairLevelStars[level - 1] = stars;
                if (unlockNextLevel < birdsPairLevels.Length)
                {
                    birdsPairLevels[unlockNextLevel] = true;
                }

                break;
        }

    }
}
