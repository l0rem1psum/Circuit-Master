using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Button : Point
{
    public TextMeshProUGUI textMesh;
    private PointOut[] OutPoints;

    private void Awake()
    {
        OutPoints = GetComponentsInChildren<PointOut>();
    }

    private void Start()
    {
        State = false;
    }
    public override void UpdatePointState()
    {
        foreach (PointOut p in OutPoints)
        {
            p.State = State;
        }
    }

    public void ToggleSwitch()
    {
        Debug.Log(State);
        State = !State;
        Debug.Log(State);
        textMesh.text = State ? "ON" : "OFF";
    }
}
