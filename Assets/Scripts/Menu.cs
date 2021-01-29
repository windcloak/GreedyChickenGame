﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("Button");
        Application.Quit();
    }

}
