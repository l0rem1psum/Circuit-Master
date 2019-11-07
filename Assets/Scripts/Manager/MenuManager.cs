using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene(0);  // Select Mode
    }
    public void SelectMode()
    {
        SceneManager.LoadScene(1);  // Select Mode
    }

    public void SelectCasual()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectExpert()
    {
        SceneManager.LoadScene(3);
    }

    public void SelectLeaderboard ()
    {
        SceneManager.LoadScene(4);
    }

    public void OptionMenu()
    {
        SceneManager.LoadScene(5);
    }

    public void SelectCasualLeaderboard()
    {
        SceneManager.LoadScene(6);
    }

    public void SelectExpertLeaderboard()
    {
        SceneManager.LoadScene(7);
    }

    public void LoadLevel(int level)
    {
        switch (level)
        {
            case 1:
                SceneManager.LoadScene(8);
                break;
            case 3:
                SceneManager.LoadScene(8);
                break;
        }
    }
}
