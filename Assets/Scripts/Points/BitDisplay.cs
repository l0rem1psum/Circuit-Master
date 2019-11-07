using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BitDisplay : Point
{
    public PointIn InPoint { get; private set; }
    public Text text;

    private void Awake()
    {
        InPoint = GetComponentInChildren<PointIn>();
    }

    // Update is called once per frame
    void Update()
    {
        State = InPoint.State;
        text.text = State ? "SUCCESS" : "WAITING";
    }
}
