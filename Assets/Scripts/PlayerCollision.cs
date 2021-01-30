using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public float foxCollision = 30f;
    public float bombCollision = 60f;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Fox")
        {
            HitPenalty(foxCollision);
        }
        if (collisionInfo.collider.tag == "Bomb")
        {
            HitPenalty(bombCollision);
        }

    }

    void HitPenalty(float pointLoss)
    {
        if (Score.score - pointLoss < 0)
        {
            PlayerMovement.ResetPlayer();
        }
        else
        {
            Score.score -= pointLoss;
        }
    }

}
