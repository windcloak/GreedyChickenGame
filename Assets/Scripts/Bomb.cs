using UnityEngine;

public class Bomb : MonoBehaviour
{
    public GameObject hitEffect;
    private void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Player")
        {
            HitPlayer();
        }

    }

    void HitPlayer()
    {
        FindObjectOfType<AudioManager>().Play("Bomb");
        Instantiate(hitEffect, transform.position, transform.rotation);   // show effect
    }
}
