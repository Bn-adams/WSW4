using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    public int moveSpeed;
    private float horizontalInput;
    private float verticalInput;
    public int jumpForce = 5;
    public bool canJump = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
        Jump();
    }


    void Movement()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector3(horizontalInput * moveSpeed, rb.velocity.y, verticalInput * moveSpeed);
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("GroundPrefab"))
        {
            canJump = true;
        }
    }
    void Jump()
    {
        if (Input.GetKey(KeyCode.Space)&&canJump)
        {
            rb.velocity = new Vector3(0, jumpForce, 0);
            canJump = false;
        }

    }
}

