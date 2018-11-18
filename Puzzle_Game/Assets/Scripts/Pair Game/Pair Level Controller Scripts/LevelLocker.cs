using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLocker : MonoBehaviour
{


    [SerializeField] //use for showing a private variable's value on Inspector.
    private PairGameSaver pairGameSaver;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private StarsLocker starsLocker;


    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject[] levelStarsHolders;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject[] levelsPadlocks;


    private bool[] animalsPairLevels; //store the levels in order to know which level is locked or not
    private bool[] birdsPairLevels; //store the levels in order to know which level is locked or not


    private void Awake()
    {
        DeactivatePadlocksAndStarHolders();
    }

    private void Start()
    {
        GetLevels();
    }

    public void CheckWhichLevelsAreUnlocked(string selectedPair)
    {
        DeactivatePadlocksAndStarHolders();

        GetLevels();

        switch (selectedPair){

            case "Animals Pair":
                for(int i=0; i<animalsPairLevels.Length; i++)
                {
                    if(animalsPairLevels[i] == true) //check if the level is unlocked
                    {
                        levelStarsHolders[i].SetActive(true); //activate stars holders
                        starsLocker.ActivateStars(i+1,selectedPair);

                    }
                    else
                    {
                        levelsPadlocks[i].SetActive(true);//activate padlock


                    }
                }
                break;

            case "Birds Pair":
                for (int i = 0; i < birdsPairLevels.Length; i++)
                {
                    if (birdsPairLevels[i] == true) //check if the level is unlocked
                    {
                        levelStarsHolders[i].SetActive(true); //activate stars holders
                        starsLocker.ActivateStars(i + 1, selectedPair);

                    }
                    else
                    {
                        levelsPadlocks[i].SetActive(true);//activate padlock


                    }
                }
                break;
        }

    }

    void DeactivatePadlocksAndStarHolders()
    {
        for(int i=0; i< levelStarsHolders.Length; i++)
        {
            levelStarsHolders[i].SetActive(false);//deactivate each element of stars
            levelsPadlocks[i].SetActive(false);//deactivate each element of padlocks
        }

    }


    void GetLevels()
    {
        animalsPairLevels = pairGameSaver.animalsPairLevels;//store the levels in order to know which level is locked or not
        birdsPairLevels = pairGameSaver.birdsPairLevels; //store the levels in order to know which level is locked or not
    }


    public bool[] GetPairLevels(string selectedPair)
    {
        switch (selectedPair)
        {

            case "Animals Pair":
                return this.animalsPairLevels;
                break;

            case "Birds Pair":
                return this.birdsPairLevels;
                break;


            default:
                return null;
                break;
        }

    }


}
