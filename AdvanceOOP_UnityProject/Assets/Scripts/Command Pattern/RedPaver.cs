// written by Grady
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPaver : Command
{    
    public override void Execute()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
}
