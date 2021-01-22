using UnityEngine;

public class YellowCandy : MonoBehaviour
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
            Score.score += candyPoints;
            CandyEaten();
        }
        
    }

    void CandyEaten()
    {
        Instantiate(eatenEffect, transform.position, transform.rotation);   // show effect
        Destroy(gameObject);    // destroy candy
    }
}
