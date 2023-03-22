// Written by Grady
// 3/18/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoEntry : State
{
    // all debugs commented for easy test case checks
    public override void AtFrontEntrance(MagicPainting painting)
    {
        painting.DeActivatePaintings();
        painting.frontPainting.GetComponent<MeshRenderer>().enabled = true;
        painting.State = new FrontEntrance();
        // Debug.Log("Entered through the Front");
    }
    public override void AtSideEntrance(MagicPainting painting)
    {
        painting.DeActivatePaintings();
        painting.sidePainting.GetComponent<MeshRenderer>().enabled = true;
        painting.State = new SideEntrance();
        // Debug.Log("Entered through the Side");
    }
    // I thought that this would be both amusing and helpful for testing, commenting them for now though
    public override void AtBedroomEntrance(MagicPainting painting)
    {
        // Debug.Log("Hacker Spotted, Commencing Ban Hammer Protocol");
    }
    public override void AtBathroomEntrance(MagicPainting painting)
    {
        // Debug.Log("Hacker Spotted, Commencing Ban Hammer Protocol");
    }
}
