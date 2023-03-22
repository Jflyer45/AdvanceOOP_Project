// Written by Grady
// 3/18/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class State
{
    public abstract void AtFrontEntrance(MagicPainting painting);
    public abstract void AtSideEntrance(MagicPainting painting);
    public abstract void AtBedroomEntrance(MagicPainting painting);
    public abstract void AtBathroomEntrance(MagicPainting painting);
}
