using UnityEngine;

public class Strawberry : MonoBehaviour
{

    public GameObject eatenEffect;
    public float strawberryPoints = 30f;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            GetStrawberry();
        }

    }

    void GetStrawberry()
    {
        FindObjectOfType<AudioManager>().Play("Coin");
        Score.score += strawberryPoints;
        Instantiate(eatenEffect, transform.position, transform.rotation);   // show effect
        Destroy(gameObject);
    }
}
