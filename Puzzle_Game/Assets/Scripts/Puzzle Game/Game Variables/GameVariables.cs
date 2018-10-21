using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class GameVariables
{
    public static int MaxRows = 3;
    public static int MaxColumns = 3;
    public static int MaxSize = MaxRows * MaxColumns;
}

public enum GameState
{
    Playing,
    Animating,
    End
}

