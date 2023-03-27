using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
public class CanSeePlayer : Conditional
{
    private FieldOfView fov;
    // Start is called before the first frame update
    public override void OnAwake()
    {
        fov = GetComponent<FieldOfView>();
    }

    public override TaskStatus OnUpdate()
    {
        if (fov.canSeePlayer)
        {
            return TaskStatus.Success;
        }
        else
        {
            return TaskStatus.Failure;
        }
    }
}
