using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject PauseMenuUI;
	
	void Update () {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
		
	}

    public void Resume()
    {
        GameIsPaused = false;
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        
    }

    public void Pause()
    {
        GameIsPaused = true;
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Quit()
    {
        SceneManager.LoadScene("Main Menu");
        Time.timeScale = 1f;
    }
}
