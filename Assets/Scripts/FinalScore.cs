using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    // Start is called before the first frame update
    public Text finalScore;

    void Start()
    {
        finalScore.text = "SCORE: " + Score.GetScore().ToString("0");
    }

    private void Update()
    {
        finalScore.text = "SCORE: " + Score.GetScore().ToString("0");
    }
}
