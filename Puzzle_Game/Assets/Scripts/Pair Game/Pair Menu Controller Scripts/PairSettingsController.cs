using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PairSettingsController : MonoBehaviour
{
    [SerializeField] //use for showing a private variable's value on Inspector.
    private MusicController musicController;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject pairSettingsPanel;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject pairMenuPanel;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Animator pairSettingsPanelAnim;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Slider slider;



    public void OpenSettingsPanel()
    {
        slider.value = musicController.GetMusicVolume();
        pairSettingsPanel.SetActive(true);
        pairSettingsPanelAnim.Play("SlideIn");
        pairMenuPanel.GetComponent<CanvasGroup>().interactable = false;
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
        pairMenuPanel.GetComponent<CanvasGroup>().interactable = true;

        pairSettingsPanel.SetActive(false); //after 1 second deactivate the game object
    }

    public void GetVolume(float volume)
    {
        musicController.SetMusicVolume(volume);
    }

    

}
