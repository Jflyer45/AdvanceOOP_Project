using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManger : Singleton<GameManger>
{
    private IAlarmObserveable alarmStation = new AlarmStation();
    void Start()
    {
        SubscribeAgentsToAlarmStation();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPlayerDeath()
    {

    }
    
    public void SetUpObjectives(List<int> ids)
    {

    }

    private void SubscribeAgentsToAlarmStation()
    {
        foreach(Guard guard in FindObjectsOfType<Guard>()) { alarmStation.Subscribe(guard); }
    }

    // Takes in a posistion of the sound, and then notifies all subscribed agents.
    public void LoudSoundNotify(Transform transform)
    {
        alarmStation.Notify(transform);
    }
}
