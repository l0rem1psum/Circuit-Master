using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Data;
using Mono.Data.Sqlite;
using UnityEngine.SceneManagement;

public class LeaderboardManager : MonoBehaviour
{
    public DatabaseManager databaseManager;

    public GameObject scorePrefab;

    public Transform parent;

    public int SceneId;
    // Start is called before the first frame update
    void Start()
    {
        DisplayGameRecords();  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void DisplayGameRecords()
    {
        string connectionString = "URI=file:" + Application.persistentDataPath + "/HighScore.sqlite";
        List<GameRecordEntity> gameRecords = databaseManager.GetRecords(SceneId, connectionString);
        for (int i = 0; i < gameRecords.Count; i++)
        {
            GameObject tmpObj = Instantiate(scorePrefab);
            GameRecordEntity tmpRecord = gameRecords[i];
            tmpObj.GetComponent<GameRecordPrefab>().SetGameRecord("#"+ (i + 1).ToString(), tmpRecord.Time.ToString("F2") + " seconds");

            tmpObj.transform.SetParent(parent);

            tmpObj.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f);
        }
    }
}
