﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public TMPro.TMP_Text currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel.text = "LEVEL " + SceneManager.GetActiveScene().buildIndex.ToString();
    }
}
