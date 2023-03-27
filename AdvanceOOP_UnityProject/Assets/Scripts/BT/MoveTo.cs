using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BehaviorDesigner.Runtime.Tasks;
using UnityEngine.AI;
public class MoveTo : Action
{
    [SerializeField] protected GameObject location;

    protected NavMeshAgent agent;

    // Start is called before the first frame update
    public override void OnAwake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    public override void OnStart()
    {
        SetUpAnimation();
    }

    public void SetUpAnimation()
    {
        /*
        if (speed == Speed.Run)
        {
            aiRoot.RunAnimation();
        }
        else if (speed == Speed.Walk)
        {
            aiRoot.WalkAnimation();
        }
        */
    }

    public override TaskStatus OnUpdate()
    {

        agent.SetDestination(location.transform.position);

        if (!agent.pathPending && !agent.isOnOffMeshLink)
        {
            if (agent.remainingDistance <= agent.stoppingDistance)
            {
                //aiRoot.IdleAnimation();
                return TaskStatus.Success;
            }
        }
        return TaskStatus.Running;
    }
}
