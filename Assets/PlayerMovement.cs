using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    public Vector2 movement;

    public Vector2 getMovement(){
        return movement;
    }
    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);
        if (movement.x < 0){
            animator.SetBool("left", true);
            animator.SetBool("right", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }
        if (movement.x > 0){
            animator.SetBool("right", true);
            animator.SetBool("left", false);
            animator.SetBool("up", false);
            animator.SetBool("down", false);
        }
        if (movement.y > 0){
            animator.SetBool("up", true);
            animator.SetBool("down", false);
            animator.SetBool("left", false);
            animator.SetBool("right", false);
        }
        if (movement.y < 0){
            animator.SetBool("down", true);
            animator.SetBool("up", false);
            animator.SetBool("left", false);
            animator.SetBool("right", false);
        }
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
