using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;
public class MoveToAlarm : MoveTo
{
    private Guard guard;

    public override void OnAwake()
    {
        base.OnAwake();
        guard = GetComponent<Guard>();
    }

    public override TaskStatus OnUpdate()
    {
        location = guard.soundLocation;
        return base.OnUpdate();
    }

    public override void OnSuccess()
    {
        base.OnSuccess();
        guard.heardSound = false;
        location = null;
    }

    public override void OnConditionalAbort()
    {
        base.OnConditionalAbort();
        guard.heardSound = false;
        location = null;
    }
}
