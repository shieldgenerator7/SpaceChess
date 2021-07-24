using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piece
{
    public Vector2Int position;
    public Vector2Int direction;
    public Engine engine;
    public bool blocking = true;//true: pieces cannot move past this piece
}
