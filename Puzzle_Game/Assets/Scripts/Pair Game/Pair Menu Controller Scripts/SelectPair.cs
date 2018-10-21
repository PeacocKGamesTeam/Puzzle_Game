using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPair : MonoBehaviour
{
    [SerializeField] //use for showing a private variable's value on Inspector.
    private PairGameManager pairGameManager;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private SelectLevel selectLevel;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private LayoutPairButtons layoutPairButtons;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject pairMenuPanel, pairLevelPanel;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Animator pairMenuPanelAnim, pairLevelPanelAnim;


    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject CanvasBackgroundImage;


    [SerializeField] //use for showing a private variable's value on Inspector.
    private string[] pairMenuButtonsName;


    [SerializeField] //use for showing a private variable's value on Inspector.
    private Sprite[] pairBackgroundImages;


    [SerializeField] //use for showing a private variable's value on Inspector.
    private Sprite[] pairButtonsBacksideImages;


    private string selectedPair;

    private int pairButtonsBacksideImagesCounter = 0;

    public void SelectedPair()
    {
        //Get the name of the current object where touching on the screen
        selectedPair = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name;

        pairGameManager.SetSelectedPair(selectedPair);

        selectLevel.SetSelectedPair(selectedPair);

        pairButtonsBacksideImagesCounter = 0;
        foreach (string btnMenuName in pairMenuButtonsName)
        {
            if (selectedPair != btnMenuName)
            {
                pairButtonsBacksideImagesCounter = pairButtonsBacksideImagesCounter + 1;

            }
            else
            {
                break;

            }

        }

        layoutPairButtons.SetSelectedPair(pairButtonsBacksideImages[pairButtonsBacksideImagesCounter]);

        StartCoroutine(ShowPairLevelPanel());

    }


    //create coroutine
    IEnumerator ShowPairLevelPanel()
    {
        pairLevelPanel.SetActive(true);//activating panel

        pairMenuPanelAnim.Play("SlideOut");//play animation
        pairLevelPanelAnim.Play("SlideIn");//play animation
        CanvasBackgroundImage.GetComponent<UnityEngine.UI.Image>().sprite = pairBackgroundImages[pairButtonsBacksideImagesCounter];
        yield return new WaitForSeconds(1f);
        pairMenuPanel.SetActive(false); //after 1 second deactivate the game object
    }


}
