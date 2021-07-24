using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct SpaceGrid<T>
{
    public const int WIDTH = 8;
    public const int HEIGHT = 8;

    private T[,] grid;

    public T this[int width, int height]
    {
        get => grid[width, height];
        set => grid[width, height] = value;
    }
    public T this[Vector2Int v]
    {
        get => grid[v.x, v.y];
        set => grid[v.x, v.y] = value;
    }

    public static SpaceGrid<T> createSpaceGrid()
    {
        SpaceGrid<T> spaceGrid = new SpaceGrid<T>();
        spaceGrid.grid = new T[WIDTH, HEIGHT];
        return spaceGrid;
    }
}
