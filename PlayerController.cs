using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    private Rigidbody2D myRigidBody;
    public float jumpSpeed;
   
    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGrounded;
    public bool isGrounded;

    public AudioSource jumpSound;
    

    void Start()
    {
        myRigidBody = GetComponent<Rigidbody2D>();
    }
  

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGrounded);

        if (Input.GetAxisRaw("Horizontal") > 0f)
        {
            myRigidBody.velocity = new Vector3(moveSpeed, myRigidBody.velocity.y, 0f);
            transform.Rotate(new Vector3(0, 0, -10));
        }
        else if (Input.GetAxisRaw("Horizontal") < 0f)
        {
            myRigidBody.velocity = new Vector3(-moveSpeed, myRigidBody.velocity.y, 0f);
            transform.Rotate(new Vector3(0, 0, 10));
        }
        else
        {
            myRigidBody.velocity = new Vector3(0f, myRigidBody.velocity.y, 0f);
        }

        if (Input.GetButton("Jump") && isGrounded)
        {
            myRigidBody.velocity = new Vector3(myRigidBody.velocity.x, jumpSpeed, 0f);
            jumpSound.Play();
        }

    }
  
}





