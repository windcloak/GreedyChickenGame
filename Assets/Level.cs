using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
    public Text currentLevel;
    // Start is called before the first frame update
    void Start()
    {
        currentLevel.text = "LEVEL " + SceneManager.GetActiveScene().buildIndex.ToString();
    }

    // Update is called once per frame
    //void Update()
    //{

    //    currentLevel.text = "LEVEL " + SceneManager.GetActiveScene().buildIndex.ToString();
    //}
}
