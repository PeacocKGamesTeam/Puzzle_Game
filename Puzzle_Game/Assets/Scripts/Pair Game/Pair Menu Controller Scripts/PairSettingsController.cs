using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PairSettingsController : MonoBehaviour
{
    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject pairSettingsPanel;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Animator pairSettingsPanelAnim;


    public void OpenSettingsPanel()
    {

        pairSettingsPanel.SetActive(true);
        pairSettingsPanelAnim.Play("SlideIn");

    }

    public void CloseSettingsPanel()
    {
        //call a coroutine
        StartCoroutine(CloseSettings());

    }

    //create coroutine
    IEnumerator CloseSettings()
    {
        pairSettingsPanelAnim.Play("SlideOut");
        yield return new WaitForSeconds(1f);
        pairSettingsPanel.SetActive(false); //after 1 second deactivate the game object
    }

}
