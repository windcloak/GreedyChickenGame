using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public bool isMoving = true;

    void FixedUpdate()
    {
        // Add a forward force
        if (isMoving)
            rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add force of 2000 on z-axis

        if (Input.GetKey("d") && isMoving)
        {
            rb
                .AddForce(sidewaysForce * Time.deltaTime,
                0,
                0,
                ForceMode.VelocityChange); // go right on x-axis
       
        }
        if (Input.GetKey("a") && isMoving)
        {
            rb
                .AddForce(-sidewaysForce * Time.deltaTime,
                0,
                0,
                ForceMode.VelocityChange); // go right on x-axis
        }


        // restart if player falls off
        if (rb.position.y < -1f && isMoving)
        {

            ResetPlayer();
        }

    }


    public static void ResetPlayer()
    {

        FindObjectOfType<GameManager>().EndGame();
        FindObjectOfType<AudioManager>().Play("PlayerReset");
        Score.Reset();

    }

}
