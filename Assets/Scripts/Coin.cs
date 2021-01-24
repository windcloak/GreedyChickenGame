using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject eatenEffect;
    public float candyPoints = 10f;
    //void OnCollisionEnter(Collision collisionInfo)
    //{
    //    if (collisionInfo.collider.name == "Player")
    //    {
    //        CandyEaten();
    //    }
    //}

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            GetCoin();
        }
        
    }

    void GetCoin()
    {
        Score.score += candyPoints;
        Instantiate(eatenEffect, transform.position, transform.rotation);   // show effect
        Destroy(gameObject);    // destroy coin
    }
}
