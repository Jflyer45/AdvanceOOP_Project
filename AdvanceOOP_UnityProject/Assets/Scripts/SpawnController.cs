using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [System.Serializable]
    public class StealableLocationPair
    {
        public int objectiveID;
        public GameObject stealable;
        public GameObject location;
    }

    public List<StealableLocationPair> stealableLocationPairs;
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

    public void SetUpSpawns()
    {
        List<int> ids = new List<int>();

        // Your code here

        // At the end pass IDs to gm
        gm.SetUpObjectives(ids);
    }
}
