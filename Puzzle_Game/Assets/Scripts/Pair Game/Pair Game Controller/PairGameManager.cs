using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PairGameManager : MonoBehaviour
{

    [SerializeField] //use for showing a private variable's value on Inspector.
    private PairGameSaver pairGameSaver;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameFinished gameFinished;

    private List<Button> pairButtons = new List<Button>();

    private List<Animator> pairButtonsAnimators = new List<Animator>();

    [SerializeField] //use for showing a private variable's value on Inspector.
    private List<Sprite> gamePairSprites = new List<Sprite>();

    private int level;
    private string selectedPair;

    private Sprite pairBackgroundImage;

    private bool firstGuess, secondGuess;

    private int firstGuessIndex, secondGuessIndex;

    private string firstGuessPair, secondGuessPair;

    private int countTryGuess;

    private int countCorrectGuess;

    private int gameGuess;

    private int starsWin;

    public void PickAPair()
    {
        if (!firstGuess)
        {
            firstGuess = true;
            firstGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            firstGuessPair = gamePairSprites[firstGuessIndex].name;

            StartCoroutine(TurnPairButtonUp(
           pairButtonsAnimators[firstGuessIndex],
           pairButtons[firstGuessIndex],
           gamePairSprites[firstGuessIndex]
           ));

        }
        else if (!secondGuess)
        {
            secondGuess = true;
            secondGuessIndex = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);

            //prevent error for double click
            if (firstGuessIndex != secondGuessIndex)
            {
                secondGuessPair = gamePairSprites[secondGuessIndex].name;

                StartCoroutine(TurnPairButtonUp(
               pairButtonsAnimators[secondGuessIndex],
               pairButtons[secondGuessIndex],
               gamePairSprites[secondGuessIndex]
               ));


                StartCoroutine(CheckIfThePairMatch(pairBackgroundImage));

                countTryGuess++;
            }
            else
            {
                secondGuess = false;
            }

        }



    }


    //coroutine to check if the buttons match
    IEnumerator CheckIfThePairMatch(Sprite pairBackgroundImage)
    {
        yield return new WaitForSeconds(1.7f);

        if(firstGuessPair == secondGuessPair)
        {
            pairButtonsAnimators[firstGuessIndex].Play("FadeOut");
            pairButtonsAnimators[secondGuessIndex].Play("FadeOut");

            //increament score
            CheckIfGameIsFinished();
        }
        else
        {

            StartCoroutine(TurnPairButtonBack(
          pairButtonsAnimators[firstGuessIndex],
          pairButtons[firstGuessIndex],
          pairBackgroundImage
          ));

            StartCoroutine(TurnPairButtonBack(
           pairButtonsAnimators[secondGuessIndex],
           pairButtons[secondGuessIndex],
           pairBackgroundImage
           ));

        }

        yield return new WaitForSeconds(.7f);
        firstGuess = secondGuess = false;
             
    }

    void CheckIfGameIsFinished()
    {
        countCorrectGuess++;

        if(countCorrectGuess == gameGuess)
        {

            //Debug.Log("Game Ends");
            CheckHowManyGuesses();
        }
    }

    void CheckHowManyGuesses()
    {
        int howManyGuesses = 0;

        switch (level)
        {
            case 1:
                howManyGuesses = 5;
                break;
            case 2:
            case 3:
                howManyGuesses = 10;
                break;
            case 4:
            case 5:
            case 6:
                howManyGuesses = 15;
                break;
            case 7:
            case 8:
            case 9:
            case 10:
                howManyGuesses = 20;
                break;
            case 11:
            case 12:
            case 13:
            case 14:
            case 15:
                howManyGuesses = 25;
                break;
        }

        if (countTryGuess < howManyGuesses)
        {
            //3 stars
            starsWin = 3;
            gameFinished.ShowGameFineshedPanel(starsWin);

            pairGameSaver.Save(level,selectedPair, starsWin);
        }else if(countTryGuess < (howManyGuesses + 5))
        {
            //2 stars
            starsWin = 2;
            gameFinished.ShowGameFineshedPanel(starsWin);
            pairGameSaver.Save(level, selectedPair, starsWin);

        }
        else
        {

            //1 stars
            starsWin = 1;
            gameFinished.ShowGameFineshedPanel(starsWin);
            pairGameSaver.Save(level, selectedPair, starsWin);
        }

    }

    public List<Animator> ResetGameplay()
    {

        firstGuess = secondGuess = false;

        countTryGuess = 0;
        countCorrectGuess = 0;

        gameFinished.HideGameFinishedPanel(starsWin);

        return pairButtonsAnimators;
    }

    //coroutine to flip the button
    IEnumerator TurnPairButtonUp(Animator anim, Button btn, Sprite pairImage)
    {

        anim.Play("TurnUp");
        yield return new WaitForSeconds(.4f);
        btn.image.sprite = pairImage;
    }

    //coroutine to flip the button back
    IEnumerator TurnPairButtonBack(Animator anim, Button btn, Sprite pairImage)
    {

        anim.Play("TurnBack");
        yield return new WaitForSeconds(.4f);
        btn.image.sprite = pairImage;
    }

    void AddListeners()
    {
        foreach (Button btn in pairButtons)
        {
            btn.onClick.RemoveAllListeners();
            btn.onClick.AddListener(() => PickAPair());
        }
    }

    public void SetUpButtonsAndAnimators(List<Button> buttons, List<Animator> animators)
    {
        this.pairButtons = buttons;
        this.pairButtonsAnimators = animators;

        gameGuess = pairButtons.Count / 2;

        //get the backround image of the buttons
        pairBackgroundImage = pairButtons[0].image.sprite;

        AddListeners();
    }


    public void SetGamePairSprites(List<Sprite> gamePairSprites)
    {
        this.gamePairSprites = gamePairSprites;
    }

    public void SetLevel(int level)
    {
        this.level = level;
    }

    public void SetSelectedPair(string selectedPair)
    {

        this.selectedPair = selectedPair;
    }
}
