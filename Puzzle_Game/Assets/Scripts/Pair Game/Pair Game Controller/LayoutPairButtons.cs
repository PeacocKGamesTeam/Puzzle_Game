using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LayoutPairButtons : MonoBehaviour
{


    [SerializeField] //use for showing a private variable's value on Inspector.
    private SetupPairGame setupPairGame;

    [SerializeField] //use for showing a private variable's value on Inspector.
    private GameObject pairLevel1, pairLevel2, pairLevel3, pairLevel4, pairLevel5, pairLevel6, pairLevel7, pairLevel8, pairLevel9, pairLevel10, pairLevel11, pairLevel12, pairLevel13, pairLevel14, pairLevel15;


    public List<Button> level1Buttons, level2Buttons, level3Buttons, level4Buttons, level5Buttons, level6Buttons, level7Buttons, level8Buttons, level9Buttons, level10Buttons, level11Buttons, level12Buttons, level13Buttons, level14Buttons, level15Buttons;

    public List<Animator> level1Anims, level2Anims, level3Anims, level4Anims, level5Anims, level6Anims, level7Anims, level8Anims, level9Anims, level10Anims, level11Anims, level12Anims, level13Anims, level14Anims, level15Anims;



    private int pairLevel;

    private string selectedPair;

    private Sprite pairButtonsBacksideImages;

    //function is called from LoadPairGame.cs
    public void LayoutButtons(int level, string pair)
    {
        this.pairLevel = level;
        this.selectedPair = pair;

        //pass the arguments to the script SetupPairGame.cs
        setupPairGame.SetLevelAndPair(pairLevel, selectedPair);

        LayoutPair();
    }


    public void SetSelectedPair(Sprite pairButtonsBacksideImages)
    {
        this.pairButtonsBacksideImages = pairButtonsBacksideImages;
        //Debug.Log("this selected pair is " + selectedPair);

    }

    //layout of our buttons
    void LayoutPair()
    {

        switch (pairLevel)
        {

            case 1:

                pairLevel1.GetComponent<GridLayoutGroup>().cellSize = new Vector2(250, 200);
                pairLevel1.GetComponent<GridLayoutGroup>().constraintCount = 3;


                foreach (Button btn in level1Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel1.transform, false);


                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;

                    }
                }

                setupPairGame.SetPairButtonsAndAnimators(level1Buttons, level1Anims);

                break;

            case 2:

                pairLevel2.GetComponent<GridLayoutGroup>().cellSize = new Vector2(200, 150);
                pairLevel2.GetComponent<GridLayoutGroup>().constraintCount = 4;


                foreach (Button btn in level2Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel2.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level2Buttons, level2Anims);

                break;

            case 3:

                pairLevel3.GetComponent<GridLayoutGroup>().cellSize = new Vector2(200, 150);
                pairLevel3.GetComponent<GridLayoutGroup>().constraintCount = 4;


                foreach (Button btn in level3Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel3.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level3Buttons, level3Anims);

                break;

            case 4:

                pairLevel4.GetComponent<GridLayoutGroup>().cellSize = new Vector2(150, 150);
                pairLevel4.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level4Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel4.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level4Buttons, level4Anims);

                break;

            case 5:

                pairLevel5.GetComponent<GridLayoutGroup>().cellSize = new Vector2(150, 150);
                pairLevel5.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level5Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel5.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level5Buttons, level5Anims);

                break;

            case 6:

                pairLevel6.GetComponent<GridLayoutGroup>().cellSize = new Vector2(150, 150);
                pairLevel6.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level6Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel6.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level6Buttons, level6Anims);

                break;

            case 7:

                pairLevel7.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 130);
                pairLevel7.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level7Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel7.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level7Buttons, level7Anims);

                break;

            case 8:

                pairLevel8.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 130);
                pairLevel8.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level8Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel8.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level8Buttons, level8Anims);

                break;

            case 9:

                pairLevel9.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 130);
                pairLevel9.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level9Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel9.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level9Buttons, level9Anims);

                break;

            case 10:

                pairLevel10.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 130);
                pairLevel10.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level10Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel10.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level10Buttons, level10Anims);

                break;

            case 11:

                pairLevel11.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 120);
                pairLevel11.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level11Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel11.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level11Buttons, level11Anims);

                break;

            case 12:

                pairLevel12.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 120);
                pairLevel12.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level12Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel12.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level12Buttons, level12Anims);

                break;

            case 13:

                pairLevel13.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 120);
                pairLevel13.GetComponent<GridLayoutGroup>().constraintCount = 6;


                foreach (Button btn in level13Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel13.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level13Buttons, level13Anims);

                break;

            case 14:

                pairLevel14.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 120);
                pairLevel14.GetComponent<GridLayoutGroup>().constraintCount = 6;

                foreach (Button btn in level14Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel14.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level14Buttons, level14Anims);

                break;

            case 15:

                pairLevel15.GetComponent<GridLayoutGroup>().cellSize = new Vector2(140, 120);
                pairLevel15.GetComponent<GridLayoutGroup>().constraintCount = 6;

                foreach (Button btn in level15Buttons)
                {
                    //if the button is not active
                    if (!btn.gameObject.activeInHierarchy)
                    {
                        btn.gameObject.SetActive(true);
                        btn.gameObject.transform.SetParent(pairLevel15.transform, false);

                        //set the back image of each btn to the appropriate back image of each category
                        btn.image.sprite = this.pairButtonsBacksideImages;
                    }


                }

                setupPairGame.SetPairButtonsAndAnimators(level15Buttons, level15Anims);

                break;
        }

    }
}
