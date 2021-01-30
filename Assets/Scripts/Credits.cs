using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void Menu()
    {

        FindObjectOfType<AudioManager>().Play("Button");
        Score.Reset();
        SceneManager.LoadScene(0);
    }


}
