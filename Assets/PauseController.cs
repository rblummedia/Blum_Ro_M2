using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseController : MonoBehaviour
{
    public bool isPaused = true; // Start in paused state

    void Start()
    {
        // Ensure the game starts paused
        Time.timeScale = 0f;
    }

    void Update()
    {
        // Toggle pause state with 'p' key
        if (Input.GetKeyUp(KeyCode.P))
        {
            isPaused = !isPaused;
            Time.timeScale = isPaused ? 0f : 1f;
        }
    }
}
