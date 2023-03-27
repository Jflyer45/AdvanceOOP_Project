using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Guard : MonoBehaviour, IAlarmSubscriber
{
    [SerializeField] private float speed;
    private NavMeshAgent agent;

    public void AlarmReact(Transform transform)
    {
        // When this runs, the agent should go towards the source of the sound transform.
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
