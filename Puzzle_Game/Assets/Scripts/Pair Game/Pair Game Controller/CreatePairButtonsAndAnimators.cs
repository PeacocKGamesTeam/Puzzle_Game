using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatePairButtonsAndAnimators : MonoBehaviour
{

    [SerializeField] //use for showing a private variable's value on Inspector.
    private LayoutPairButtons layoutPairButtons;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private Button pairButton;

    //how many buttons in each pair game we have.
    private int pairGame1 = 6;
    private int pairGame2 = 12;
    private int pairGame3 = 12;
    private int pairGame4 = 18;
    private int pairGame5 = 18;
    private int pairGame6 = 18;
    private int pairGame7 = 24;
    private int pairGame8 = 24;
    private int pairGame9 = 24;
    private int pairGame10 = 24;
    private int pairGame11 = 30;
    private int pairGame12 = 30;
    private int pairGame13 = 30;
    private int pairGame14 = 30;
    private int pairGame15 = 30;


    private List<Button> level1Buttons = new List<Button>();
    private List<Button> level2Buttons = new List<Button>();
    private List<Button> level3Buttons = new List<Button>();
    private List<Button> level4Buttons = new List<Button>();
    private List<Button> level5Buttons = new List<Button>();
    private List<Button> level6Buttons = new List<Button>();
    private List<Button> level7Buttons = new List<Button>();
    private List<Button> level8Buttons = new List<Button>();
    private List<Button> level9Buttons = new List<Button>();
    private List<Button> level10Buttons = new List<Button>();
    private List<Button> level11Buttons = new List<Button>();
    private List<Button> level12Buttons = new List<Button>();
    private List<Button> level13Buttons = new List<Button>();
    private List<Button> level14Buttons = new List<Button>();
    private List<Button> level15Buttons = new List<Button>();


    private List<Animator> level1Anims = new List<Animator>();
    private List<Animator> level2Anims = new List<Animator>();
    private List<Animator> level3Anims = new List<Animator>();
    private List<Animator> level4Anims = new List<Animator>();
    private List<Animator> level5Anims = new List<Animator>();
    private List<Animator> level6Anims = new List<Animator>();
    private List<Animator> level7Anims = new List<Animator>();
    private List<Animator> level8Anims = new List<Animator>();
    private List<Animator> level9Anims = new List<Animator>();
    private List<Animator> level10Anims = new List<Animator>();
    private List<Animator> level11Anims = new List<Animator>();
    private List<Animator> level12Anims = new List<Animator>();
    private List<Animator> level13Anims = new List<Animator>();
    private List<Animator> level14Anims = new List<Animator>();
    private List<Animator> level15Anims = new List<Animator>();


    void Awake()
    {
        CreateButtons();
        GetAnimators();
    }

    void Start()
    {
        AssignButtonsAndAnims();
    }

    void AssignButtonsAndAnims()
    {

        layoutPairButtons.level1Buttons = level1Buttons;
        layoutPairButtons.level2Buttons = level2Buttons;
        layoutPairButtons.level3Buttons = level3Buttons;
        layoutPairButtons.level4Buttons = level4Buttons;
        layoutPairButtons.level5Buttons = level5Buttons;
        layoutPairButtons.level6Buttons = level6Buttons;
        layoutPairButtons.level7Buttons = level7Buttons;
        layoutPairButtons.level8Buttons = level8Buttons;
        layoutPairButtons.level9Buttons = level9Buttons;
        layoutPairButtons.level10Buttons = level10Buttons;
        layoutPairButtons.level11Buttons = level11Buttons;
        layoutPairButtons.level12Buttons = level12Buttons;
        layoutPairButtons.level13Buttons = level13Buttons;
        layoutPairButtons.level14Buttons = level14Buttons;
        layoutPairButtons.level15Buttons = level15Buttons;

        layoutPairButtons.level1Anims = level1Anims;
        layoutPairButtons.level2Anims = level2Anims;
        layoutPairButtons.level3Anims = level3Anims;
        layoutPairButtons.level4Anims = level4Anims;
        layoutPairButtons.level5Anims = level5Anims;
        layoutPairButtons.level6Anims = level6Anims;
        layoutPairButtons.level7Anims = level7Anims;
        layoutPairButtons.level8Anims = level8Anims;
        layoutPairButtons.level9Anims = level9Anims;
        layoutPairButtons.level10Anims = level10Anims;
        layoutPairButtons.level11Anims = level11Anims;
        layoutPairButtons.level12Anims = level12Anims;
        layoutPairButtons.level13Anims = level13Anims;
        layoutPairButtons.level14Anims = level14Anims;
        layoutPairButtons.level15Anims = level15Anims;


    }

    void CreateButtons()
    {

        //Create buttons for Level 1
        for(int i=0; i<pairGame1; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level1Buttons.Add(btn);

        }

        //Create buttons for Level 2
        for (int i = 0; i < pairGame2; i++)
        {
            Button btn = Instantiate(pairButton); //Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level2Buttons.Add(btn);

        }

        //Create buttons for Level 3
        for (int i = 0; i < pairGame3; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level3Buttons.Add(btn);

        }

        //Create buttons for Level 4
        for (int i = 0; i < pairGame4; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level4Buttons.Add(btn);

        }

        //Create buttons for Level 5
        for (int i = 0; i < pairGame5; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level5Buttons.Add(btn);

        }

        //Create buttons for Level 6
        for (int i = 0; i < pairGame6; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level6Buttons.Add(btn);

        }

        //Create buttons for Level 7
        for (int i = 0; i < pairGame7; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level7Buttons.Add(btn);

        }

        //Create buttons for Level 8
        for (int i = 0; i < pairGame8; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level8Buttons.Add(btn);

        }

        //Create buttons for Level 9
        for (int i = 0; i < pairGame9; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level9Buttons.Add(btn);

        }

        //Create buttons for Level 10
        for (int i = 0; i < pairGame10; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level10Buttons.Add(btn);

        }

        //Create buttons for Level 11
        for (int i = 0; i < pairGame11; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level11Buttons.Add(btn);

        }

        //Create buttons for Level 12
        for (int i = 0; i < pairGame12; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level12Buttons.Add(btn);

        }


        //Create buttons for Level 13
        for (int i = 0; i < pairGame13; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level13Buttons.Add(btn);

        }

        //Create buttons for Level 14
        for (int i = 0; i < pairGame14; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level14Buttons.Add(btn);

        }

        //Create buttons for Level 15
        for (int i = 0; i < pairGame15; i++)
        {
            Button btn = Instantiate(pairButton);//Instantiate: create an object copy of the object that we pass as an argument
            btn.gameObject.name = "" + i;//rename the object
            level15Buttons.Add(btn);

        }
    }

    void GetAnimators()
    {

        for(int i=0; i<level1Buttons.Count; i++)
        {
            level1Anims.Add(level1Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level1Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level2Buttons.Count; i++)
        {
            level2Anims.Add(level2Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level2Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level3Buttons.Count; i++)
        {
            level3Anims.Add(level3Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level3Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level4Buttons.Count; i++)
        {
            level4Anims.Add(level4Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level4Buttons[i].gameObject.SetActive(false); //deactivate the button
        }


        for (int i = 0; i < level5Buttons.Count; i++)
        {
            level5Anims.Add(level5Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level5Buttons[i].gameObject.SetActive(false); //deactivate the button
        }


        for (int i = 0; i < level6Buttons.Count; i++)
        {
            level6Anims.Add(level6Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level6Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level7Buttons.Count; i++)
        {
            level7Anims.Add(level7Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level7Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level8Buttons.Count; i++)
        {
            level8Anims.Add(level8Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level8Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level9Buttons.Count; i++)
        {
            level9Anims.Add(level9Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level9Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level10Buttons.Count; i++)
        {
            level10Anims.Add(level10Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level10Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level11Buttons.Count; i++)
        {
            level11Anims.Add(level11Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level11Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level12Buttons.Count; i++)
        {
            level12Anims.Add(level12Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level12Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level13Buttons.Count; i++)
        {
            level13Anims.Add(level13Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level13Buttons[i].gameObject.SetActive(false); //deactivate the button
        }


        for (int i = 0; i < level14Buttons.Count; i++)
        {
            level14Anims.Add(level14Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level14Buttons[i].gameObject.SetActive(false); //deactivate the button
        }

        for (int i = 0; i < level15Buttons.Count; i++)
        {
            level15Anims.Add(level15Buttons[i].gameObject.GetComponent<Animator>());//add the animator component of the button to the list
            level15Buttons[i].gameObject.SetActive(false); //deactivate the button
        }
    }
}
