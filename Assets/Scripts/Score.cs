using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public static float score = 0f;

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = player.position.z.ToString("0");
        scoreText.text = score.ToString("0");
    }

}
