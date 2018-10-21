using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    private GameObject[] puzzlePieces;
    private Sprite[] puzzleImages;

    private PuzzlePiece[,] matrix = new PuzzlePiece[GameVariables.MaxRows,GameVariables.MaxColumns];

    private Vector3 screenPositionToAnimate;
    private PuzzlePiece pieceToAnimate;
    private int toAnimateRow, toAnimateColumn;

    private float animSpeed = 10f;

    private int puzzleIndex;

    private GameState gameState;


    private void Awake()
    {
        MakeSingleton();
    }

    // Start is called before the first frame update
    void Start()
    {
        puzzleIndex = -1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnLevelWasLoaded()
    {
        if (Application.loadedLevelName == "Gameplay")
        {
            if(puzzleIndex > 0)
            {
                LoadPuzzle();
                GameStarted();
            }
        }
    }

    void GameStarted()
    {
        int index = Random.Range(0, GameVariables.MaxSize);

        puzzlePieces[index].SetActive(false);

        for(int row = 0; row < GameVariables.MaxRows; ++row)
        {
            for(int column = 0; column < GameVariables.MaxColumns; ++column)
            {
                if(puzzlePieces[row * GameVariables.MaxColumns + column].activeInHierarchy)
                {
                    Vector3 point = GetScreenCoordinatesFromViewPort(row, column);
                    puzzlePieces[row * GameVariables.MaxColumns + column].transform.position = point;

                    matrix[row, column] = new PuzzlePiece();
                    matrix[row, column].GameObject = puzzlePieces[row * GameVariables.MaxColumns + column];
                    matrix[row, column].OriginalRow = row;
                    matrix[row, column].OriginalColumn = column;
                }
                else
                {
                    matrix[row, column] = null;
                }
            }
        }
    }


    private Vector3 GetScreenCoordinatesFromViewPort(int row, int column)
    {
        Vector3 point = Camera.main.ViewportToWorldPoint(new Vector3(0.289f * row, 1 - 0.294f * column, 0));
        point.z = 0;
        return point;
    }

    void LoadPuzzle()
    {
        puzzleImages = Resources.LoadAll<Sprite>("Sprites/Gameplay/Puzzle Game/Tutorial Puzzle Images/BG " + puzzleIndex);

        puzzlePieces = GameObject.Find("Puzzle Holder").GetComponent<PuzzleHolder>().puzzlePieces;

        for(int i = 0; i < puzzlePieces.Length; ++i)
        {
            puzzlePieces[i].GetComponent<SpriteRenderer>().sprite = puzzleImages[i];
        }

    }

    void MakeSingleton()
    {
        if(instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    
    public void SetPuzzleIndex(int puzzleIndex)
    {
        this.puzzleIndex = puzzleIndex;

        //Debug.Log("The Puzzle index is: " + this.puzzleIndex);
    }

}
