using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FIVEPMPlayerScript : MonoBehaviour
{
    //This variable is for our speed
    public float speed;
    //This variable is for our jump height
    public float jump;
    //this variable is for our rigidbody game physics
    public Rigidbody2D physics;

    //This variable checks if were on the ground
    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //If I press the D Key 
        if (Input.GetKey(KeyCode.D))
        {
            //Move my player position to the right
            //transform.Translate(transform.right * speed * Time.deltaTime);

            physics.velocity = new Vector2(speed, physics.velocity.y);

        }

    }
}
