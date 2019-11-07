using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wire : MonoBehaviour
{
    public Point begin;
    public Point end;
    protected LineRenderer line;

    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        // The end of the wire must have the same state as the beginning
        end.State = begin.State;

        // Change line color
        if (begin.State)
        {
            line.startColor = Color.black;
            line.endColor = Color.black;
        } else
        {
            line.startColor = Color.white;
            line.endColor = Color.white;
        }   
    }
}
