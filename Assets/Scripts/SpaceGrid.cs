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
        get => grid[Mathf.Clamp(width, 0, WIDTH - 1), Mathf.Clamp(height, 0, HEIGHT - 1)];
        set => grid[Mathf.Clamp(width, 0, WIDTH - 1), Mathf.Clamp(height, 0, HEIGHT - 1)] = value;
    }
    public T this[Vector2Int v]
    {
        get => this[v.x, v.y];
        set => this[v.x, v.y] = value;
    }

    public static SpaceGrid<T> createSpaceGrid()
    {
        SpaceGrid<T> spaceGrid = new SpaceGrid<T>();
        spaceGrid.grid = new T[WIDTH, HEIGHT];
        return spaceGrid;
    }
}
