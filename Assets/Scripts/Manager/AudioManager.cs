using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AudioManager : MonoBehaviour
{
    public Slider slider;

    private AudioSource audioSource;

    private void Start()
    {
        slider.value = audioSource.volume;
    }

    private void Awake()
    {
        GameObject gameObject = GameObject.FindGameObjectsWithTag("Music")[0];
        audioSource = gameObject.GetComponentInChildren<AudioSource>();  
    }

    private void Update()
    {
        audioSource.volume = slider.value;
    }

}
