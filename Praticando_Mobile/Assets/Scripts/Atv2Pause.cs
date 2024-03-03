using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atv2Pause : MonoBehaviour
{
    private bool isPaused;

    void Start()
    {
        isPaused = false;
        Time.timeScale = 1f;
    }

    public void GamePause()
    {
        isPaused = !isPaused;

        if (isPaused)
            Time.timeScale = 0f;
        else
            Time.timeScale = 1f;
    }

    void OnApplicationPause()
    {
        isPaused = true;
        Time.timeScale = 0f;
    }
}
