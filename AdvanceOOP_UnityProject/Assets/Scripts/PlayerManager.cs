using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    private GameManger gm;

    // Start is called before the first frame update
    void Start()
    {
        gm = FindObjectOfType<GameManger>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDeath()
    {
        //call gm here to tell the gamemanager to reset scene
        //gm.OnPlayerDeath();
        // This method should be called whenever the player dies, like being touched by a guard.
        // Remove these comments on completion.
    }
}
