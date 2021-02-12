using UnityEngine;
using UnityEngine.UI;

public class LevelCompleteScore : MonoBehaviour
{
    public Text levelCompleteScore;

    void Start()
    {
        levelCompleteScore.text = "SCORE: " + Score.GetScore().ToString("0");
        Score.UpdateLastScore();    // update score to score at last level
    }

}
