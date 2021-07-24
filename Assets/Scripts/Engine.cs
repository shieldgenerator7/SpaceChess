using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Engine
{
    protected virtual int Range => 8;

    protected delegate bool PositionFunction(int x, int y, Vector2Int v);
    protected abstract PositionFunction ValidMoveFunction { get; }

    public Piece piece;
    public SpaceGrid<bool> getMovement(SpaceGrid<Piece> grid)
    {
        int range = Range;
        PositionFunction validMoveFunction = ValidMoveFunction;
        SpaceGrid<bool> moves = SpaceGrid<bool>.createSpaceGrid();
        Vector2Int v = piece.position;
        //Add cells in range
        for (int i = v.x - range; i <= v.x + range; i++)
        {
            for (int j = v.y - range; j <= v.y + range; j++)
            {
                if (validMoveFunction(i, j, v))
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

    protected PositionFunction HorizontalVertical
        => (x, y, v) => x == v.x || y == v.y;

    protected PositionFunction Diagonal
        => (x, y, v) => Mathf.Abs(x - v.x) == Mathf.Abs(y - v.y);
}
