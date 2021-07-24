using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Engine
{
    public Piece piece;
    public abstract SpaceGrid<bool> getMovement(SpaceGrid<Piece> grid);
}
