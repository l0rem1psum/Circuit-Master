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
    public DatabaseManager databaseManager;
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
        string connectionString = "URI=file:" + Application.persistentDataPath + "/HighScore.sqlite";

        int[] scenes = { 10, 11, 12, 13, 14 };

        List<GameRecordEntity> gameRecords = databaseManager.GetRecords(10, connectionString);
        long score = Convert.ToInt64(gameRecords[0].Time * 1000);
        Leaderboards.e1.SubmitScore(score);

        gameRecords.Clear();
        gameRecords = databaseManager.GetRecords(11, connectionString);
        score = Convert.ToInt64(gameRecords[0].Time * 1000);
        Leaderboards.e2.SubmitScore(score);

        gameRecords.Clear();
        gameRecords = databaseManager.GetRecords(12, connectionString);
        score = Convert.ToInt64(gameRecords[0].Time * 1000);
        Leaderboards.e3.SubmitScore(score);

        gameRecords.Clear();
        gameRecords = databaseManager.GetRecords(13, connectionString);
        score = Convert.ToInt64(gameRecords[0].Time * 1000);
        Leaderboards.c1.SubmitScore(score);

        gameRecords.Clear();
        gameRecords = databaseManager.GetRecords(14, connectionString);
        score = Convert.ToInt64(gameRecords[0].Time * 1000);
        Leaderboards.c2.SubmitScore(score);
    }

}
