using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GuardFlyWeight : Singleton<GuardFlyWeight>
{
    [SerializeField] private float standardSpeed;
    [SerializeField] private float maxHealth;
    [SerializeField] private float maxStamina;
    [SerializeField] private float maxAmmo;

    public float StandardSpeed
    {
        get { return standardSpeed; }
    }

    public float MaxHealth
    {
        get { return maxHealth; }
    }

    public float MaxStamina
    {
        get { return maxStamina; }
    }

    public float MaxAmmo
    {
        get { return maxAmmo; }
    }
}
