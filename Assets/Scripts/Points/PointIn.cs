using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointIn : Point
{
    // Wire connected to the point (in/out)
    public Wire inWire;
    public override void UpdatePointState()
    {
        State = inWire.end.State;
    }
}
