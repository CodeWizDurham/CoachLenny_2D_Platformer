using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SIXPMMovementScript : MonoBehaviour
{
    //This variable is gonna be for our player speed
    public float speed;

    //This line of code is for our player's jump
    public float jumpPower;

    //This allows our player to use game physics!
    public Rigidbody2D physics;

    //This variable is in charge of our player movement
    private Vector2 PlayerInput;

    //This is our jump key!
    public KeyCode JumpButton;

    //This variable is responsible for our ground check!
    private bool isGrounded;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "ground")
        {
            isGrounded = true;
        }       
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //Setting our Player Input variable to be the Axises our player will move on
        PlayerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        //physics.velocity is setting a new speed for our player on the X axis
        physics.velocity = new Vector2(PlayerInput.x * speed, physics.velocity.y);


        if (Input.GetKeyDown(JumpButton))
        {
            physics.velocity = new Vector2( physics.velocity.x , speed);
        }
    }
}
