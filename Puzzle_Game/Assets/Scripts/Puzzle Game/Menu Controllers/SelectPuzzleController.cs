using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectPuzzleController : MonoBehaviour
{
    public void SelectPuzzle()
    {
        string[] name = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject.name.Split();

        int index = int.Parse(name[1]);

        if(GameManager.instance != null)
        {
            GameManager.instance.SetPuzzleIndex(index);
        }

        //Debug.Log("You selected puzzle number: " + index);

        Application.LoadLevel("Gameplay");
    }

    public void BackToMainMenu()
    {
        Application.LoadLevel("MainMenu");
    }
}
