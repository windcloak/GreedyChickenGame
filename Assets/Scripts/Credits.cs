using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

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
