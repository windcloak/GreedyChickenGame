using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Fox" || collisionInfo.collider.tag == "Bomb")
        {
            PlayerMovement.ResetPlayer();
        }

    }

}
