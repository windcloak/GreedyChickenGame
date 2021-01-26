using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public static float score = 0f;

    // Update is called once per frame
    void Update()
    {
        scoreText.text = score.ToString("0");
    }

    public static void Reset()
    {
        score = 0;
    }

    public static float GetScore()
    {
        return score;
    }

}
