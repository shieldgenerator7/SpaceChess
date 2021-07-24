using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnEngine : Engine
{
    protected override int Range => 1;
    protected override PositionFunction ValidMoveFunction =>
        (x, y, v) =>
        {
            Vector2Int pos = (v + piece.direction);
            return x == pos.x && y == pos.y;
        };
}
