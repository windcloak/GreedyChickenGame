using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{

    public void Quit()
    {
        Debug.Log("quit");
        Application.Quit();
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }
}
