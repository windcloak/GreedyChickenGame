using UnityEngine;

public class Fox : MonoBehaviour
{

    public GameObject hitEffect;
    private void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
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
