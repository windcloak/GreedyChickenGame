using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Credits : MonoBehaviour
{
    public void Quit()
    {
        Debug.Log("quit");
        FindObjectOfType<AudioManager>().Play("Button");
        Application.Quit();
    }

    public void Replay()
    {

        FindObjectOfType<AudioManager>().Play("Button");
        Score.Reset();
        SceneManager.LoadScene(1);
    }


}
