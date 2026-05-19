using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    bool isAlive = true;
    bool ok;
    SpriteRenderer mySpriteRenderer;
    BoxCollider2D myBoxCollider;
    Rigidbody2D rb;
    Movement script;
    Animator myAnimator;
    void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
        myBoxCollider = GetComponent<BoxCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        script = GetComponent<Movement>();
        myAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        Die();
    }

    void Die()
    {
        if(rb.IsTouchingLayers(LayerMask.GetMask("Enemy", "Hazards")))
            isAlive = false;

        if(isAlive)
            return;
        else if(!ok)
        {
            ok = true;
           
            myAnimator.SetTrigger("isDead");
           
            myBoxCollider.enabled = isAlive;
            script.enabled = isAlive;
 
            rb.bodyType = RigidbodyType2D.Static;
        }
    }
}
