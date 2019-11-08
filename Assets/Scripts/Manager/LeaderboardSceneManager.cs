using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LeaderboardSceneManager : MonoBehaviour
{
    public void OpenLeaderboard(int sceneId)
    {
        SceneManager.LoadScene(sceneId);
    }

    public void LoadLeaderboardLevel(int level)
    {
        switch (level)
        {
            case 1:
                SceneManager.LoadScene(15);
                break;
            case 2:
                SceneManager.LoadScene(16);
                break;
            case 3:
                SceneManager.LoadScene(17);
                break;
            case 4:
                SceneManager.LoadScene(18);
                break;
            case 5:
                SceneManager.LoadScene(19);
                break;
        }
    }
}
