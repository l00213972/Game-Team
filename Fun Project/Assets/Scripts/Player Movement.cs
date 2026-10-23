using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float playerMovementSpeed = 5f;
    public float spinSpeed = 2f;
    public float acceleration = 20f;
    public float deceleration = 15f;


    private bool isGrounded;
    public static bool gravityFlipped = false;

    // Movement
    private Rigidbody2D rb;
    public float moveinput;

    // Position
    Vector3 startPosition;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        // The position where the player is at in the beginning
        startPosition = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        moveinput = Input.GetAxisRaw("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            PlayerJump();
        }

    }

    private void FixedUpdate()
    {
        float targetSpeed = moveinput * playerMovementSpeed;

        float speedChange;

        if (moveinput != 0)
        {
            // Accelerate while holding a direction
            speedChange = acceleration;
        }
        else
        {
            // Decelerate when no input
            speedChange = deceleration;
        }

        float newVelocityX = Mathf.MoveTowards(rb.velocity.x, targetSpeed, speedChange * Time.fixedDeltaTime);

        rb.velocity = new Vector2(newVelocityX, rb.velocity.y);
    }

    public void PlayerJump()
    {
        gravityFlipped = !gravityFlipped;

        if (gravityFlipped)
        {
            rb.gravityScale = -2f;
        }
        else
        {
            rb.gravityScale = 2f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // When hits a spike or enemy
        if (collision.gameObject.CompareTag("Damage"))
        {
            UIHolder.playerHealth -= 1;

            // Move the player back to the start
            transform.position = startPosition;
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = false;
        }
    }

}
