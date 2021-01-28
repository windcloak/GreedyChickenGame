using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteScore : MonoBehaviour
{
    public TMPro.TMP_Text levelCompleteScore;

    void Start()
    {
        levelCompleteScore.text = "SCORE: " + Score.GetScore().ToString("0");
    }

}
