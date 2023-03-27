using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;

public class HearAlarm : Conditional
{
    public Guard guard;

    public override void OnAwake()
    {
        guard = GetComponent<Guard>();
    }

    public override TaskStatus OnUpdate()
    {
        if (guard.heardSound)
        {
            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Failure;
        }
    }
}
