using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsLocker : MonoBehaviour
{
    [SerializeField] //use for showing a private variable's value on Inspector.
    private PairGameSaver pairGameSaver;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject[] level1Stars, level2Stars, level3Stars, level4Stars, level5Stars, level6Stars, level7Stars, level8Stars, level9Stars, level10Stars, level11Stars, level12Stars, level13Stars, level14Stars, level15Stars;


    public int[] animalsPairLevelStars;
    public int[] birdsPairLevelStars;

   
    public void ActivateStars(int level, string selectedPair)
    {
        GetStars();

        int stars;

        switch (selectedPair)
        {
            case "Animals Pair":

                stars = animalsPairLevelStars[level-1]; //get how many stars we have in this particular level
                ActivateLevelStars(level, stars);
                break;

            case "Birds Pair":

                stars = birdsPairLevelStars[level-1]; //get how many stars we have in this particular level
                ActivateLevelStars(level, stars);
                break;
        }
    }

    void ActivateLevelStars(int level, int looper)
    {

        switch (level)
        {
            case 1:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for(int i=0; i<looper; i++)
                    {
                        level1Stars[i].SetActive(true);

                    }

                }

                break;

            case 2:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level2Stars[i].SetActive(true);

                    }

                }

                break;

            case 3:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level3Stars[i].SetActive(true);

                    }

                }

                break;

            case 4:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level4Stars[i].SetActive(true);

                    }

                }

                break;

            case 5:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level5Stars[i].SetActive(true);

                    }

                }

                break;

            case 6:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level6Stars[i].SetActive(true);

                    }

                }

                break;

            case 7:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level7Stars[i].SetActive(true);

                    }

                }

                break;

            case 8:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level8Stars[i].SetActive(true);

                    }

                }

                break;

            case 9:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level9Stars[i].SetActive(true);

                    }

                }

                break;

            case 10:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level10Stars[i].SetActive(true);

                    }

                }

                break;

            case 11:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level11Stars[i].SetActive(true);

                    }

                }

                break;

            case 12:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level12Stars[i].SetActive(true);

                    }

                }

                break;

            case 13:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level13Stars[i].SetActive(true);

                    }

                }

                break;

            case 14:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level14Stars[i].SetActive(true);

                    }

                }

                break;

            case 15:
                if (looper != 0) // if the looper is equal to 0 means that we don't have any star so we dont need to do a for loop for the stars
                {
                    for (int i = 0; i < looper; i++)
                    {
                        level15Stars[i].SetActive(true);

                    }

                }

                break;

        }
    }

    public void DeactivateStars()
    {
        for (int i = 0; i < level1Stars.Length; i++)//number of stars are the same in each level
        {
            level1Stars[i].SetActive(false);
            level2Stars[i].SetActive(false);
            level3Stars[i].SetActive(false);
            level4Stars[i].SetActive(false);
            level5Stars[i].SetActive(false);
            level6Stars[i].SetActive(false);
            level7Stars[i].SetActive(false);
            level8Stars[i].SetActive(false);
            level9Stars[i].SetActive(false);
            level10Stars[i].SetActive(false);
            level11Stars[i].SetActive(false);
            level12Stars[i].SetActive(false);
            level13Stars[i].SetActive(false);
            level14Stars[i].SetActive(false);
            level15Stars[i].SetActive(false);
        }
    }

    void GetStars()
    {
        animalsPairLevelStars = pairGameSaver.animalsPairLevelStars;
        birdsPairLevelStars = pairGameSaver.birdsPairLevelStars;

    }

}
