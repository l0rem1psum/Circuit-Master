using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRecordEntity : IComparable<GameRecordEntity>
{
    public float Time { get; set; }
    public int SceneId { get; set; }

    public GameRecordEntity(int sceneId, float time)
    {
        this.SceneId = sceneId;
        this.Time = time;
    }

    public int CompareTo(GameRecordEntity other)
    {
        if (other.Time < this.Time)
        {
            return 1;
        }
        else if (other.Time > this.Time)
        {
            return -1;
        }
        else
        {
            return 0;
        }
    }
}
