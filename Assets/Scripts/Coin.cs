﻿using UnityEngine;

public class Coin : MonoBehaviour
{
    public GameObject eatenEffect;
    public float candyPoints = 10f;

    private void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            GetCoin();
        }
        
    }

    void GetCoin()
    {
        FindObjectOfType<AudioManager>().Play("Coin");
        Score.score += candyPoints;
        Instantiate(eatenEffect, transform.position, transform.rotation);   // show effect
        Destroy(gameObject);    // destroy coin
    }
}
