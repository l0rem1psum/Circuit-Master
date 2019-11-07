using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelector : MonoBehaviour
{
    public void Casual()
    {
        SceneManager.LoadScene(2);
    }

    public void Expert()
    {
        SceneManager.LoadScene(3);
    }
}
