using UnityEngine;

public class EscMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject escMenuUI;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();   // press Esc twice to resume game
            }
            else
            {
                Pause();
            }
        }
        else if (Input.GetKeyDown(KeyCode.Tab))
        {
            PauseMenu();   // go to Pause menu
        }
    }

    public void Resume()
    {
        escMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Pause()
    {
        escMenuUI.SetActive(true);
        // freeze time 
        Time.timeScale = 0f;
        GameIsPaused = true;

        // press Enter to leave game
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            QuitGame();
        }
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    void PauseMenu()
    {
        escMenuUI.SetActive(false);
    }
}
