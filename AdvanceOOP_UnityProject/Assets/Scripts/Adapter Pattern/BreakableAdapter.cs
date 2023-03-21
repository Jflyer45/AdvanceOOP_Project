using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableAdapter : Breakable, IBreakable
{
    public void BreakFunction(BreakableVersion version = BreakableVersion.Enhanced)
    {
        if (version == BreakableVersion.Enhanced)
        {
            GameManger.Instance.LoudSoundNotify(transform);
        }
        BreakFunction();
        Debug.Log("Test!");
    }

    public void CrackFunction(BreakableVersion version = BreakableVersion.Enhanced)
    {
        if (version == BreakableVersion.Enhanced)
        {
            GameManger.Instance.LoudSoundNotify(transform);
        }
        CrackFunction();
    }

    /*
    protected override void OnTriggerEnter(Collider other)
    {
        Debug.Log("asdasd");
        if (BreakOnCollision)
        {

            if (other.GetComponent<Rigidbody>() != null)
            {
                SpeedOfOther = other.GetComponent<Rigidbody>().velocity.magnitude;
            }
            if (ThisRigidbody != null)
            {
                SpeedOfSelf = ThisRigidbody.velocity.magnitude;
            }
            float CombinedSpeed = SpeedOfOther + SpeedOfSelf;

            if (CombinedSpeed >= SpeedRequiredToBreak)
            {

                BreakFunction();
            }
        }
    }
    */
}
