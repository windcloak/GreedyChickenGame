using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static float score = 0f;
    private static float lastScore = 0f;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("0");
    }

    public static void UpdateLastScore()
    {
        lastScore = score;
    }

    public static void Reset()
    {
        score = lastScore;
    }

    public static float GetScore()
    {
        return score;
    }

}
