using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingEngine : Engine
{
    protected override int Range => 1;
    protected override PositionFunction ValidMoveFunction => (x, y, z) => true;

}
