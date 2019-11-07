using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NandGate : Gate
{
    public override void UpdateGateState()
    {
        bool output = true;
        foreach (PointIn point in InPoints)
        {
            output = output && point.State;
        }

        foreach (PointOut point in OutPoints)
        {
            point.State = !output;
        }
    }
}
