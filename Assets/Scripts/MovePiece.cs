using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePiece : MonoBehaviour
{
    public void movePiece(Piece piece, SpaceGrid<Piece> grid, Vector2Int v)
    {
        grid[piece.position] = null;
        piece.position = v;
        grid[piece.position] = piece;
    }
}
