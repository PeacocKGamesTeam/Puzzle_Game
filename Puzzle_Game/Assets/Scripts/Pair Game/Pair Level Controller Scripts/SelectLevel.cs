using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectLevel : MonoBehaviour
{
    [SerializeField] //use for showing a private variable's value on Inspector.
    private PairGameManager pairGameManager;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private LevelLocker levelLocker;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private LoadPairGame loadPairGame;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject pairMenuPanel, pairLevelPanel;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Animator pairMenuPanelAnim, pairLevelPanelAnim;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject CanvasBackgroundImage;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Sprite MenuBackgroundImage;


    private string selectedPair;

    private bool[] pair;

    public void BackToPairMenuPanel()
    {
        StartCoroutine(ShowPairMenuPanel());

    }

    public void SelectPairLevel()
    {

        int level = int.Parse(UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name);
        pair = levelLocker.GetPairLevels(selectedPair); //get the level of the selected pair

        if (pair[level-1])//if the level is unlocked then you are able to play
        {
            pairGameManager.SetLevel(level);
            loadPairGame.LoadPair(level, selectedPair);
        }

        
    }

    //create coroutine
    IEnumerator ShowPairMenuPanel()
    {
        pairMenuPanel.SetActive(true);//activating panel
        pairMenuPanel.GetComponent<CanvasGroup>().interactable = false;
        pairMenuPanelAnim.Play("SlideIn");//play animation
        pairLevelPanelAnim.Play("SlideOut");//play animation
        CanvasBackgroundImage.GetComponent<UnityEngine.UI.Image>().sprite = MenuBackgroundImage;
        yield return new WaitForSeconds(1f);
        pairLevelPanel.SetActive(false); //after 1 second deactivate the game object
        pairMenuPanel.GetComponent<CanvasGroup>().interactable = true;
    }


    public void SetSelectedPair(string selectedPair)
    {
        this.selectedPair = selectedPair;
        //Debug.Log("this selected pair is " + selectedPair);

    }
}
