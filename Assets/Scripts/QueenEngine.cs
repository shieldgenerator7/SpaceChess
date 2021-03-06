using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenEngine : Engine
{
    protected override PositionFunction ValidMoveFunction
        => (x, y, v) => HorizontalVertical(x, y, v) || Diagonal(x, y, v);
}
