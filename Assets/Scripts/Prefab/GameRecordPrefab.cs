using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameRecordPrefab : MonoBehaviour
{
    public GameObject rank;
    public GameObject time;

    public void SetGameRecord(string rank, string time)
    {
        this.rank.GetComponent<Text>().text = rank;
        this.time.GetComponent<Text>().text = time;
    }
}
