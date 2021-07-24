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
        //Verify moves are not blocked
        for (int r = 1; r <= range; r++)
        {
            for (int i = v.x - r; i <= v.x + r; i++)
            {
                for (int j = v.y - r; j <= v.y + r; j++)
                {
                    //Only look at positions in this ring
                    if (Mathf.Abs(i - v.x) == r || Mathf.Abs(j - v.y) == r)
                    {
                        //Only look at positions that are valid
                        if (moves[i, j] == true)
                        {
                            //If the cell directly "below" is invalid,
                            if (moves[reduceInt(i), reduceInt(j)] == false)
                            {
                                //this cell is invalid
                                moves[i, j] = false;
                            }
                            //If the cell is not empty
                            else if (grid[i, j] != piece && grid[i, j] != null && grid[i, j].blocking)
                            {
                                //this cell is invalid
                                moves[i, j] = false;
                            }
                        }
                    }
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

    private int reduceInt(int i)
    {
        return (i != 0) ? i - (int)Mathf.Sign(i) : 0;
    }
}
