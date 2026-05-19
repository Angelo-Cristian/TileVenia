using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] int speed = 1;
    Rigidbody2D rb;
    CapsuleCollider2D myCapsuleCollider;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        myCapsuleCollider = GetComponent<CapsuleCollider2D>();
    }

    void Update()
    {
        rb.velocity = new Vector2(speed, 0f);
        
        Flip();
    }

    void Flip()
    {
        if(!myCapsuleCollider.IsTouchingLayers(LayerMask.GetMask("Ground")))
            return;
        else
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, 1f);
            speed *= -1;
        }
            
    }
}
