using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingEngine : Engine
{
    public override SpaceGrid<bool> getMovement(SpaceGrid<Piece> grid)
    {
        SpaceGrid<bool> moves = SpaceGrid<bool>.createSpaceGrid();
        Vector2Int v = piece.position;
        //Add cells in range
        for (int i = v.x - 1; i <= v.x + 1; i++)
        {
            for (int j = v.y - 1; j <= v.y + 1; j++)
            {
                moves[i, j] = true;
            }
        }
        //Remove current cell
        moves[v.x, v.y] = false;
        //Return moves
        return moves;
    }
}
