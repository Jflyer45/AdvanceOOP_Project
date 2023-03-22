using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBreakable
{
    public void BreakFunction(BreakableVersion version);

    public void CrackFunction(BreakableVersion version);
}
