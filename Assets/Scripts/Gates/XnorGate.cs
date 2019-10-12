using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XnorGate : Gate
{
    public override void UpdateGateState()
    {
        int trueInputCount = 0;

        foreach (PointIn point in InPoints)
        {
            if (point.State == true)
            {
                trueInputCount++;
            }
        }

        bool output = trueInputCount % 2 == 0;

        foreach (PointOut point in OutPoints)
        {
            point.State = output;
        }
    }
}
