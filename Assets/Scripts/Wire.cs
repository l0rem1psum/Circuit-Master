using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public Point begin;
    public Point end;

    // Update is called once per frame
    void Update()
    {
        // The end of the wire must have the same state as the beginning
        end.State = begin.State;
    }
}
