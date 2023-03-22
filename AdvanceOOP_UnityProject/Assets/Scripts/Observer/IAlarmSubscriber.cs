using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IAlarmSubscriber
{
    void AlarmReact(Transform transform);
}
