using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableAdapter : Breakable, IBreakable
{
    public bool notifySound;
    public new void BreakFunction()
    {
        if (notifySound)
        {
            GameManger.Instance.LoudSoundNotify(transform);
        }

        base.BreakFunction();
        Debug.Log("Test!");
    }

    protected override void OnCollisionEnter(Collision other)
    {
        if (BreakOnCollision)
        {

            if (other.rigidbody != null)
            {
                SpeedOfOther = other.rigidbody.velocity.magnitude;
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
}
