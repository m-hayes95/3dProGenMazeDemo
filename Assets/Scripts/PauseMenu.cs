using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public bool gameIsPaused = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            PauseGame();
        }
        
    }
    public void PauseGame()
    {
        pauseMenu.SetActive(true);
        // Stop time with time scale.
        Time.timeScale = 0f;
    }
    public void ResumeGame() 
    {
        pauseMenu.SetActive(false);
        // Set time scale to default.
        Time.timeScale = 1f;
    }

    public void QuitGame() 
    {
        Application.Quit();
    }
}
