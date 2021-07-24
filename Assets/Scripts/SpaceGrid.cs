using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceGrid
{
    public const int WIDTH = 8;
    public const int HEIGHT = 8;

    private Piece[,] grid = new Piece[WIDTH, HEIGHT];

    public Piece this[int width, int height]
    {
        get => grid[width, height];
        set => grid[width, height] = value;
    }
    public Piece this[Vector2Int v]
    {
        get => grid[v.x, v.y];
        set => grid[v.x, v.y] = value;
    }
}
