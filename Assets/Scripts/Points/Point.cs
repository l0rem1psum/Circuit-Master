﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    //public bool State { get; set; }
    public bool State;

    // Update is called once per frame
    void Update()
    {
        UpdatePointState();
    }

    public virtual void UpdatePointState() 
    {
    }
}
