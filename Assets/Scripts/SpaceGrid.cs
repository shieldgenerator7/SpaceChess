using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceGrid
{
    public const int WIDTH = 8;
    public const int HEIGHT = 8;

    private int[,] grid = new int[WIDTH, HEIGHT];

    public int this[int width, int height]
    {
        get => grid[width, height];
        set => grid[width, height] = value;
    }
}
