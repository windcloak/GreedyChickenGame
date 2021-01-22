using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public GameObject eatCandyEffect;

    void OnCollisionEnter(Collision collisionInfo) {
        if (collisionInfo.collider.name == "Obstacle") {
            //movement.enabled = false;
            //FindObjectOfType<GameManager>().EndGame();
            EatCandy();
        }
    }

    void EatCandy()
    {
        Debug.Log("Got candy");
        // increase score                            
    }
}
