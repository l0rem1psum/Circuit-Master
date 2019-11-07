using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NotGate : Gate
{
    public override void UpdateGateState()
    {
        foreach(PointOut point in OutPoints)
        {
            point.State = !OutPoints[0].State;
        }
    }
}
