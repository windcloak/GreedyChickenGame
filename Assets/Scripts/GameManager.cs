using UnityEngine;
using UnityEngine.SceneManagement;  // need to change or reload scene

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    bool isFinalLevel = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 2)
        {
            isFinalLevel = true;
        }

        if (!isFinalLevel)
        {

            completeLevelUI.SetActive(true);
        }
        else
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }

    public void EndGame()
    {
        if (!gameHasEnded)
        {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", restartDelay);
        }

    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
