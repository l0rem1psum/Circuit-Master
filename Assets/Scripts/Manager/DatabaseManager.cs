using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Data;
using Mono.Data.Sqlite;
using System.IO;

public class DatabaseManager : MonoBehaviour
{

    //public GameObject scorePrefab;

    //public Transform parent;

    //public int SceneId;

    private string connectionString;

    private List<GameRecordEntity> gameRecords = new List<GameRecordEntity>();
    // Start is called before the first frame update
    void Start()
    {
        string filePath = Application.persistentDataPath + "/HighScore.sqlite";
        connectionString = "URI=file:" + Application.persistentDataPath + "/HighScore.sqlite";
        Debug.Log(connectionString);
        Debug.Log(Application.persistentDataPath);
        Debug.Log(Application.dataPath);
        //DisplayGameRecords();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public List<GameRecordEntity> GetRecords(int sceneId, string connectionString)
    {
        gameRecords.Clear();

        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "SELECT * FROM leaderboard WHERE scene_id = " + sceneId.ToString() + ";";
                Debug.Log(sqlQuery);
                dbCmd.CommandText = sqlQuery;

                using (IDataReader reader = dbCmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        gameRecords.Add(new GameRecordEntity(reader.GetInt32(1), reader.GetFloat(2)));
                        Debug.Log(reader.GetInt32(1));
                    }
                    dbConnection.Close();
                    reader.Close();
                }
            }
        }
        gameRecords.Sort();
        return gameRecords;
    }

    public void SetRecord(int sceneId, float time)
    {
        using (IDbConnection dbConnection = new SqliteConnection(connectionString))
        {
            dbConnection.Open();
            using (IDbCommand dbCmd = dbConnection.CreateCommand())
            {
                string sqlQuery = "INSERT INTO leaderboard(scene_id, time) VALUES(" + sceneId.ToString() + "," + time.ToString() + ");";
                dbCmd.CommandText = sqlQuery;

                dbCmd.ExecuteScalar();
                dbConnection.Close();
            }
        }
    }

    //private void displaygamerecords()
    //{
    //    getrecords(sceneid);
    //    for (int i = 0; i < gamerecords.count; i++)
    //    {
    //        gameobject tmpobj = instantiate(scoreprefab);
    //        gamerecordentity tmprecord = gamerecords[i];
    //        tmpobj.getcomponent<gamerecordprefab>().setgamerecord("#" + (i + 1).tostring(), tmprecord.time.tostring() + " seconds");

    //        tmpobj.transform.setparent(parent);

    //        tmpobj.getcomponent<recttransform>().localscale = new vector3(1f, 1f);
    //    }
    //}

}
