using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NorGate : Gate
{
    public override void UpdateGateState()
    {
        bool output = false;

        foreach (PointIn point in InPoints)
        {
            if (point.State == true)
            {
                output = true;
                break;
            }
            output = output || point.State;
        }

        foreach (PointOut point in OutPoints)
        {
            point.State = !output;
        }
    }
}
