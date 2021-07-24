using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightEngine : Engine
{
    protected override int Range => 2;
    protected override PositionFunction ValidMoveFunction =>
        (x, y, v) => Mathf.Abs(x - v.x) * 2 == Mathf.Abs(y - v.y) || Mathf.Abs(x - v.x) == Mathf.Abs(y - v.y) * 2;
}
