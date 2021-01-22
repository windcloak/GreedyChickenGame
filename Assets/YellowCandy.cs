using UnityEngine;

public class YellowCandy : MonoBehaviour
{
    public GameObject eatenEffect;
    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.name == "Player")
        {
            CandyEaten();
        }
    }
     
    void CandyEaten()
    {
        Instantiate(eatenEffect, transform.position, transform.rotation);   // show effect
        Destroy(gameObject);    // destroy candy
    }
}
