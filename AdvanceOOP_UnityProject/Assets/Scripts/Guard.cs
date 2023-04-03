using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Guard : MonoBehaviour, IAlarmSubscriber
{
    #region
    // Instrinsic
    private float standardSpeed = GuardFlyWeight.Instance.StandardSpeed;
    private float maxHealth = GuardFlyWeight.Instance.MaxHealth;
    private float maxStamina = GuardFlyWeight.Instance.MaxStamina;
    private float maxAmmo = GuardFlyWeight.Instance.MaxAmmo;

    // Extrinsic
    public bool heardSound = false;
    public Transform soundLocation;
    private NavMeshAgent agent;
    #endregion
    public void AlarmReact(Transform aTransform)
    {
        // When this runs, the agent should go towards the source of the sound transform.
        heardSound = true;
        soundLocation = aTransform;
        
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
