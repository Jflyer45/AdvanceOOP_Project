// Written by Grady
// 3/18/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicPainting : MonoBehaviour
{
    // Gives reference to specific painting
    // gameobjects that can be hand picked
    [SerializeField] public GameObject frontPainting;
    [SerializeField] public GameObject sidePainting;
    [SerializeField] public GameObject bedroomPainting;
    [SerializeField] public GameObject bathroomPainting;
    
    // State variable
    private State state = new NoEntry();
    public State State
    {
        get { return this.state; }
        set { this.state = value; }
    }
    // starts off with the NoEntry()
    // method to have specific possibilities
    public MagicPainting()
    {
        this.State = new NoEntry();
    }

    // ActivatePaintings() and DeActivatePaintings() act as
    // a quick turn visibility on paintings on or off switch.    
    // ActivatePaintings is never used, but is here in case
    // it is needed during future changes.
    public void ActivatePaintings()
    {
        this.frontPainting.GetComponent<MeshRenderer>().enabled = true;
        this.sidePainting.GetComponent<MeshRenderer>().enabled = true;
        this.bedroomPainting.GetComponent<MeshRenderer>().enabled = true;
        this.bathroomPainting.GetComponent<MeshRenderer>().enabled = true;
    }
    public void DeActivatePaintings()
    {
        this.frontPainting.GetComponent<MeshRenderer>().enabled = false;
        this.sidePainting.GetComponent<MeshRenderer>().enabled = false;
        this.bedroomPainting.GetComponent<MeshRenderer>().enabled = false;
        this.bathroomPainting.GetComponent<MeshRenderer>().enabled = false;
    }
    public void AtFrontEntrance()
    {
        this.State.AtFrontEntrance(this);
    }
    public void AtSideEntrance()
    {
        this.State.AtSideEntrance(this);
    }
    public void AtBedroomEntrance()
    {
        this.State.AtBedroomEntrance(this);
    }
    public void AtBathroomEntrance()
    {
        this.State.AtBathroomEntrance(this);
    }
}
