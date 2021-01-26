using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;

    void FixedUpdate()
    {
        // Add a forward force
        rb.AddForce(0, 0, forwardForce * Time.deltaTime); // add force of 2000 on z-axis

        if (Input.GetKey("d"))
        {
            rb
                .AddForce(sidewaysForce * Time.deltaTime,
                0,
                0,
                ForceMode.VelocityChange); // go right on x-axis
       
        }
        if (Input.GetKey("a"))
        {
            rb
                .AddForce(-sidewaysForce * Time.deltaTime,
                0,
                0,
                ForceMode.VelocityChange); // go right on x-axis
        }


        // restart if player falls off
        if (rb.position.y < -1f)
        {
            ResetPlayer();
        }

    }

    void ResetPlayer()
    {

        FindObjectOfType<GameManager>().EndGame();
        FindObjectOfType<AudioManager>().Play("PlayerReset");
        Debug.Log("reset");
        Score.Reset();

    }

}
