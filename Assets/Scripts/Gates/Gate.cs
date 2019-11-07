using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour

{
    public PointIn[] InPoints { get; private set; }
    public PointOut[] OutPoints { get; private set; }
    
    private void Awake()
    {
        InPoints = GetComponentsInChildren<PointIn>();
        OutPoints = GetComponentsInChildren<PointOut>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateGateState();
    }

    public virtual void UpdateGateState()
    { 
    }
}
