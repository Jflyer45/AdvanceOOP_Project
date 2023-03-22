// Written by Grady
// 3/18/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontEntrance : State
{
    // all debugs commented for easy test case checks
    public override void AtFrontEntrance(MagicPainting painting)
    {
        // Debug.Log("Detected through the Front");
    }
    public override void AtSideEntrance(MagicPainting painting)
    {
        painting.DeActivatePaintings();
        painting.sidePainting.GetComponent<MeshRenderer>().enabled = true;
        painting.State = new SideEntrance();
        // Debug.Log("Detected at the Side");
    }
    public override void AtBedroomEntrance(MagicPainting painting)
    {
        painting.DeActivatePaintings();
        painting.bedroomPainting.GetComponent<MeshRenderer>().enabled = true;
        painting.State = new StairSideBedroomEntrance();
        // Debug.Log("Detected in the Bedroom");
    }
    public override void AtBathroomEntrance(MagicPainting painting)
    {
        painting.DeActivatePaintings();
        painting.bathroomPainting.GetComponent<MeshRenderer>().enabled = true;
        painting.State = new BathroomSideBedroomEntrance();
        // Debug.Log("Detected at the Bathroom");
    }
}
