using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointOut : Point
{
    // Wire connected to the point (in/out)
    public Wire outWire;
    public override void UpdatePointState()
    {
        outWire.begin.State = State;
    }
}
