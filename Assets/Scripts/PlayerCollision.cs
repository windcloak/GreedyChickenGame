using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

    public PlayerMovement movement;
    public float foxCollision = 30f;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Fox")
        {
            Score.score -= foxCollision;
            Debug.Log("you hit the fox!");
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
