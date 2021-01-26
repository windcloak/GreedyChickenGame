using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public float foxCollision = 30f;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Fox")
        {
            if (Score.score - foxCollision < 0)
            {
                PlayerMovement.ResetPlayer();
            } else
            {

            Score.score -= foxCollision;
            }
        }

    }

    //void OnCollisionEnter(Collision collisionInfo)
    //{
    //    if (collisionInfo.collider.tag == "Fox")
    //    {
    //        //movement.enabled = false;
    //        //FindObjectOfType<GameManager>().EndGame();
    //    }
    //}

}
