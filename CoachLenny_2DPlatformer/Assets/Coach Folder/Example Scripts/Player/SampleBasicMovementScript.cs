using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleBasicMovementScript : MonoBehaviour
{
    //This variable is for our speed
    public float speed;
    //This variable is for our jump height
    public float jump;
    //this variable is for our rigidbody game physics
    public Rigidbody2D physics;

    //This variable checks if were on the ground
    public bool isGrounded;

    void Update()
    {
        //If I press the D Key 
        if (Input.GetKey(KeyCode.D))
        {
            //Move my player position to the right
            //transform.Translate(transform.right * speed * Time.deltaTime);

            physics.velocity = new Vector2(speed,physics.velocity.y);

        }

        //If I press the A Key 
        if (Input.GetKey(KeyCode.A))
        {
            //Move my player position to the right
            //transform.Translate(transform.right * -speed * Time.deltaTime);

            physics.velocity = new Vector2(-1 * speed, physics.velocity.y);
        }

        
        // & = and
        // || = or
        

        //If I press the Space Key Down and I am grounded
        if (Input.GetKeyDown(KeyCode.Space) & isGrounded)
        {
            //Create a Local variable Vector2 JumpForce and apply jump to the Y column of the new Vector2 below
            //physics.velocity = new Vector2(physics.velocity.x, jump);

            //Create a new Vector2 variable that = new Vector2(physics.velocity.x, jump);
            Vector2 JumpForce = new Vector2(physics.velocity.x, jump);
            //Apply the new variable in the Addforce method of your rigidbody variable
            physics.AddForce(JumpForce);
        }
    }

    //Checks to see the first collision between two objects
    private void OnCollisionEnter2D(Collision2D other)
    {
        //if is touching a object then is grounded
        isGrounded = true;

        //if is touching an object with the ground tag then is grounded
        //if (other.gameObject.tag == "ground")
        //{
        //    isGrounded = true;
        //}

    }

    //Checks to see the last collision between two objects
    private void OnCollisionExit2D(Collision2D other)
    {
        //if is not touching a object then is not grounded
        isGrounded = false;

        //if is touching an object with the ground tag then is grounded
        //if (other.gameObject.tag == "ground")
        //{
        //    isGrounded = false;
        //}
    }
}

