using UnityEngine;

public class Fox : MonoBehaviour
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
        FindObjectOfType<AudioManager>().Play("Fox");
        Instantiate(hitEffect, transform.position, transform.rotation);   // show effect
    }
}
