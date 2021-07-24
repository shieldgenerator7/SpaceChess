using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenEngine : Engine
{
    public const int RANGE = 8;

    public override SpaceGrid<bool> getMovement(SpaceGrid<Piece> grid)
    {
        SpaceGrid<bool> moves = SpaceGrid<bool>.createSpaceGrid();
        Vector2Int v = piece.position;
        //Add cells in range
        for (int i = v.x - RANGE; i <= v.x + RANGE; i++)
        {
            for (int j = v.y - RANGE; j <= v.y + RANGE; j++)
            {
                //Horizontal and Vertical
                if (i == v.x || j == v.y
                    //Horizontal
                    || Mathf.Abs(i - v.x) == Mathf.Abs(j - v.y)
                    )
                {
                    moves[i, j] = true;
                }
            }
        }
        //Remove current cell
        moves[v.x, v.y] = false;
        //Return moves
        return moves;
    }
}
