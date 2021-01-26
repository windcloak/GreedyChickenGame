using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    private PlayerMovement movement;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
        movement.enabled = false;
    }
}
 
