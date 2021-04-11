using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed;
    public float jumpHeight;
    public Rigidbody2D rb;
    public SpriteRenderer sp;

    // Start is called before the first frame update
    void Start()
    {

    }

    private void FixedUpdate()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(xInput * moveSpeed, rb.velocity.y);
        if (Math.Abs(rb.velocity.y) < 0.01)
        {
            rb.velocity = new Vector2(xInput * moveSpeed, yInput * jumpHeight);
        }
        if (xInput < 0)
        {
            sp.flipX = true;
        }
        else
        {
            sp.flipX = false;
        }

    }
    // Update is called once per frame
    void Update()
    {

    }
}
