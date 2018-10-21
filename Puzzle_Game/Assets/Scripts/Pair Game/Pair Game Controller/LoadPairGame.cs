using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadPairGame : MonoBehaviour
{
    [SerializeField] //use for showing a private variable's value on Inspector.
    private PairGameManager pairGameManager;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private LayoutPairButtons layoutPairButtons;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject pairLevelPanel;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Animator pairLevelPanelAnim;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject pairGamePanel1, pairGamePanel2, pairGamePanel3, pairGamePanel4, pairGamePanel5, pairGamePanel6, pairGamePanel7, pairGamePanel8, pairGamePanel9, pairGamePanel10, pairGamePanel11, pairGamePanel12, pairGamePanel13, pairGamePanel14, pairGamePanel15;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Animator pairGamePanelAnim1, pairGamePanelAnim2, pairGamePanelAnim3, pairGamePanelAnim4, pairGamePanelAnim5, pairGamePanelAnim6, pairGamePanelAnim7, pairGamePanelAnim8, pairGamePanelAnim9, pairGamePanelAnim10, pairGamePanelAnim11, pairGamePanelAnim12, pairGamePanelAnim13, pairGamePanelAnim14, pairGamePanelAnim15;

    private int pairLevel;

    private string selectedPair;

    private List<Animator> anims;

    //function is called from SelectLevel.cs
    public void LoadPair(int level, string pair)
    {
        this.pairLevel = level;
        this.selectedPair = pair;

        //call function of LayoutPairButtons.cs
        layoutPairButtons.LayoutButtons(pairLevel, selectedPair);

        switch (pairLevel)
        {
            case 1:
                StartCoroutine(LoadPairGamePanel(pairGamePanel1, pairGamePanelAnim1));
                break;

            case 2:
                StartCoroutine(LoadPairGamePanel(pairGamePanel2, pairGamePanelAnim2));
                break;

            case 3:
                StartCoroutine(LoadPairGamePanel(pairGamePanel3, pairGamePanelAnim3));
                break;

            case 4:
                StartCoroutine(LoadPairGamePanel(pairGamePanel4, pairGamePanelAnim4));
                break;

            case 5:
                StartCoroutine(LoadPairGamePanel(pairGamePanel5, pairGamePanelAnim5));
                break;

            case 6:
                StartCoroutine(LoadPairGamePanel(pairGamePanel6, pairGamePanelAnim6));
                break;

            case 7:
                StartCoroutine(LoadPairGamePanel(pairGamePanel7, pairGamePanelAnim7));
                break;

            case 8:
                StartCoroutine(LoadPairGamePanel(pairGamePanel8, pairGamePanelAnim8));
                break;

            case 9:
                StartCoroutine(LoadPairGamePanel(pairGamePanel9, pairGamePanelAnim9));
                break;

            case 10:
                StartCoroutine(LoadPairGamePanel(pairGamePanel10, pairGamePanelAnim10));
                break;

            case 11:
                StartCoroutine(LoadPairGamePanel(pairGamePanel11, pairGamePanelAnim11));
                break;

            case 12:
                StartCoroutine(LoadPairGamePanel(pairGamePanel12, pairGamePanelAnim12));
                break;

            case 13:
                StartCoroutine(LoadPairGamePanel(pairGamePanel13, pairGamePanelAnim13));
                break;

            case 14:
                StartCoroutine(LoadPairGamePanel(pairGamePanel14, pairGamePanelAnim14));
                break;

            case 15:
                StartCoroutine(LoadPairGamePanel(pairGamePanel15, pairGamePanelAnim15));
                break;
        }
    }

    public void BackToPairLevelPanel()
    {


        anims = pairGameManager.ResetGameplay();

        switch (pairLevel)
        {
            case 1:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel1, pairGamePanelAnim1));
                break;

            case 2:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel2, pairGamePanelAnim2));
                break;

            case 3:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel3, pairGamePanelAnim3));
                break;

            case 4:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel4, pairGamePanelAnim4));
                break;

            case 5:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel5, pairGamePanelAnim5));
                break;

            case 6:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel6, pairGamePanelAnim6));
                break;

            case 7:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel7, pairGamePanelAnim7));
                break;

            case 8:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel8, pairGamePanelAnim8));
                break;

            case 9:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel9, pairGamePanelAnim9));
                break;

            case 10:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel10, pairGamePanelAnim10));
                break;

            case 11:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel11, pairGamePanelAnim11));
                break;

            case 12:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel12, pairGamePanelAnim12));
                break;

            case 13:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel13, pairGamePanelAnim13));
                break;

            case 14:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel14, pairGamePanelAnim14));
                break;

            case 15:
                StartCoroutine(LoadPairLevelPanel(pairGamePanel15, pairGamePanelAnim15));
                break;

        }
    }

    //create coroutine
    IEnumerator LoadPairLevelPanel(GameObject pairGamePanel, Animator pairGamePanelAnim)
    {
        pairLevelPanel.SetActive(true);
        pairLevelPanelAnim.Play("SlideIn");
        pairGamePanelAnim.Play("SlideOut");

        yield return new WaitForSeconds(1f);

        //reset animation to idle in order to fix the problem when click back button to levels.
        foreach(Animator anim in anims)
        {
            anim.Play("Idle");
        }

        yield return new WaitForSeconds(.5f);

        pairGamePanel.SetActive(false);
    }

    //create coroutine
    IEnumerator LoadPairGamePanel(GameObject pairGamePanel, Animator pairGamePanelAnim)
    {

        pairGamePanel.SetActive(true);
        pairGamePanelAnim.Play("SlideIn");
        pairLevelPanelAnim.Play("SlideOut");
        yield return new WaitForSeconds(1f);
        pairLevelPanel.SetActive(false);
      
    }

}
