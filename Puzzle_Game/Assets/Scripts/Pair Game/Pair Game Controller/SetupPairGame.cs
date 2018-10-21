using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SetupPairGame : MonoBehaviour
{
    [SerializeField] //use for showing a private variable's value on Inspector.
    private PairGameManager pairGameManager;

    private Sprite[] animalsPairSprites, birdsPairSprites;

   
    private List<Sprite> gamePair = new List<Sprite>();

    private List<Button> pairButtons = new List<Button>();

    private List<Animator> pairButtonsAnimators = new List<Animator>();

    private int level;
    private string selectedPair;

    private int looper;

    void Awake()
    {

        //get all the images from the resource folder
        animalsPairSprites = Resources.LoadAll<Sprite>("Sprites/Gameplay/Pair Game/Animals");
        birdsPairSprites = Resources.LoadAll<Sprite>("Sprites/Gameplay/Pair Game/Birds");
    }

    void PrepareGameSprite()
    {
        //clear the list of images because each time we select new level we want to have different pieces
        gamePair.Clear();
        gamePair = new List<Sprite>();

        int index = 0;

        switch (level)
        {

            case 1:
                looper = 6;
                break;
            case 2:
            case 3:
                looper = 12;
                break;
            case 4:
            case 5:
            case 6:
                looper = 18;
                break;
            case 7:
            case 8:
            case 9:
            case 10:
                looper = 24;
                break;
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                looper = 30;
                break;

        }


        switch(selectedPair)
        {
            case "Animals Pair":

                for (int i=0; i<looper; i++)
                {

                    if(index == (looper / 2))
                    {
                        //initialize again the index in order to add again the same images of already added images.
                        index = 0;
                    }

                    gamePair.Add(animalsPairSprites[index]);

                    index++;

                }
                    

                break;

            case "Birds Pair":

                for (int i = 0; i < looper; i++)
                {

                    if (index == (looper / 2))
                    {
                        index = 0;
                    }

                    gamePair.Add(birdsPairSprites[index]);

                    index++;

                }

                break;


        }

        Shuffle(gamePair);

    }

    void Shuffle(List<Sprite> list)
    {

        for (int i = 0; i < list.Count; i++)
        {
            Sprite temp = list[i];
            int randomIndex = Random.Range(i, list.Count);
            list[i] = list[randomIndex];
            list[randomIndex] = temp;
        }

    }

    public void SetLevelAndPair(int level, string selectedPair)
    {
        this.level = level;
        this.selectedPair = selectedPair;

        PrepareGameSprite();

        pairGameManager.SetGamePairSprites(this.gamePair);
    }

    public void SetPairButtonsAndAnimators(List<Button> pairButtons, List<Animator> pairButtonsAnimators)
    {
        this.pairButtons = pairButtons;
        this.pairButtonsAnimators = pairButtonsAnimators;

        pairGameManager.SetUpButtonsAndAnimators(pairButtons, pairButtonsAnimators);
    }
}
