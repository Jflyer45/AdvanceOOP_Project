using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAlarmObserveable
{
    void Notify(Transform transform);
    void Subscribe(IAlarmSubscriber alarmSubscriber);
}
