using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    Vector2 movementValue;
    Vector2 climbingValue;
    Rigidbody2D rb;
    Animator myAnimator;
    BoxCollider2D myBoxCollider;
    CircleCollider2D myCircleCollider;
    [SerializeField] int speed;
    [SerializeField] int jumpPower;
    [SerializeField] int climbingSpeed;
    float playerGravityScale;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myAnimator = GetComponent<Animator>();
        myBoxCollider = GetComponent<BoxCollider2D>();
        myCircleCollider = GetComponentInChildren<CircleCollider2D>();
        playerGravityScale = rb.gravityScale;
    }

    void Update()
    {
        Run();
        Flip();
        IsClimbing();
    }

    void OnMove(InputValue value)
    {
        movementValue = value.Get<Vector2>();
    }
    
    void Run()
    {
        rb.velocity = new Vector2(movementValue.x * speed, rb.velocity.y);

        bool isMoving = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;
        myAnimator.SetBool("isWalking", isMoving);
    }

    void OnJump(InputValue value)
    {
        if(value.isPressed && myCircleCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
        {
            rb.velocity = new Vector2(0f, jumpPower);
        }
    }

    void OnClimb(InputValue value)
    {
        climbingValue = value.Get<Vector2>();
    }

    void IsClimbing()
    {
        if(myCircleCollider.IsTouchingLayers(LayerMask.GetMask("Ladder")))
        {
            rb.velocity = new Vector2(rb.velocity.x, climbingValue.y * climbingSpeed);
            rb.gravityScale = 0f;

            bool isClimbing = Mathf.Abs(rb.velocity.y) > Mathf.Epsilon;
            myAnimator.SetBool("isClimbing", isClimbing);
        }
        else
        {
            rb.gravityScale = playerGravityScale;
            myAnimator.SetBool("isClimbing", false);
        }
    }

    void Flip()
    {
        bool isMoving = Mathf.Abs(rb.velocity.x) > Mathf.Epsilon;

        if(isMoving)
        {
            transform.localScale = new Vector2 (Mathf.Sign(rb.velocity.x), 1f);
        }
    }
}
