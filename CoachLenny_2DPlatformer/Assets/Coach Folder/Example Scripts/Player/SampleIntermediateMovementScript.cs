using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;
public class SampleIntermediateMovementScript : MonoBehaviour
{
    [Range(1f,10f)]
    public float speed;

    [Range(1f, 10f)]
    public float jumpPower;

    public KeyCode JumpButton;

    private Vector2 PlayerInput;

    public Rigidbody2D physics;

    private bool isGrounded;


    public void Move()
    {
        PlayerInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));

        physics.velocity = new Vector2(PlayerInput.x * speed, physics.velocity.y);
    }

    public void Jump()
    {
        if (Input.GetKey(JumpButton) & isGrounded)
        {
            physics.velocity = new Vector2(physics.velocity.x, jumpPower);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "ground")
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

    private void FixedUpdate()
    {
        Move();
        Jump();
    }
}
