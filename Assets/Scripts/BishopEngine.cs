using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopEngine : Engine
{
    protected override PositionFunction ValidMoveFunction => (x, y, v) => Diagonal(x, y, v);
}
