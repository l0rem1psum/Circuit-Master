using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitDisplay : MonoBehaviour
{
    public PointIn InPoint { get; private set; }

    public bool State;

    private void Awake()
    {
        InPoint = GetComponentInChildren<PointIn>();
    }

    // Update is called once per frame
    void Update()
    {
        State = InPoint.State;
        Debug.Log(State);
    }
}
