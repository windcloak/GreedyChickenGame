using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public Text currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        // checks if we are at last level
        if (SceneManager.GetActiveScene().buildIndex == SceneManager.sceneCountInBuildSettings - 1)
        {
            Debug.Log("we at last level");
        }
        currentLevel.text = "LEVEL " + SceneManager.GetActiveScene().buildIndex.ToString();
    }

    // Update is called once per frame
    //void Update()
    //{

    //    currentLevel.text = "LEVEL " + SceneManager.GetActiveScene().buildIndex.ToString();
    //}
}
