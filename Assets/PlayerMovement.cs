using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    // void Start()
    // {
    //     rb.AddForce(0, 200, 500);
    // }
    // We marked this as FixedUpdate b/c we are using it to mess with physics
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, 2000 * Time.deltaTime); // add force of 2000 on z-axis
    }
}
