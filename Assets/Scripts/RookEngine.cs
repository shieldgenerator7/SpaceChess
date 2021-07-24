using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RookEngine : Engine
{
    protected override PositionFunction ValidMoveFunction => (x, y, v) => HorizontalVertical(x, y, v);
}
