using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmStation : IAlarmObserveable
{
    List<IAlarmSubscriber> subscribers = new List<IAlarmSubscriber>();

    public void Notify(Transform transform)
    {
        foreach(IAlarmSubscriber sub in subscribers)
        {
            sub.AlarmReact(transform);
        }
    }

    public void Subscribe(IAlarmSubscriber alarmSubscriber)
    {
        subscribers.Add(alarmSubscriber);
    }
}
