using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public BitDisplay bitDisplay;
    public float timeStart = 0;
    public TextMeshProUGUI text;

    private bool timerActive = true;

    // Start is called before the first frame update
    void Start()
    {
        text.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        // Successfully completed the level
        if (bitDisplay.State)
        {
            timerActive = false;
            EndLevel();
        }

        if (timerActive)
        {
            timeStart += Time.deltaTime;
            text.text = timeStart.ToString("F2");
        }   
    }

    public void PauseMenu()
    {
        timerActive = !timerActive;
    }

    private void EndLevel()
    {
        GameObject win = GameObject.Find("/Camera/Canvas/Win");

        TextMeshProUGUI[] congText = win.GetComponentsInChildren<TextMeshProUGUI>();
        Debug.Log(congText.Length);
        congText[1].text = "You complete the level in " + timeStart.ToString("F2") + " seconds.";


        win.SetActive(true);
    }
}
