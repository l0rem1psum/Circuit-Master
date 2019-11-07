using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using CloudOnce;
using TMPro;
using System.Globalization;
using System;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI text;

    private void Start()
    {
        Cloud.OnInitializeComplete += CloudOnceInitializeComplete;
        Cloud.Initialize(false, true);
    }

    public void CloudOnceInitializeComplete()
    {
        Cloud.OnInitializeComplete -= CloudOnceInitializeComplete;
        Debug.Log("Initialized");
    }

    public void SubmitScore()
    {
        Debug.Log(text.text);
        Leaderboards.AnotherLeaderboard.SubmitScore(1);
    }

}
