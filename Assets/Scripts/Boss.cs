using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private SpriteRenderer spriteRenderer;
    private Animator animator;
    Transform player;
    Transform boss;
    private bool isFacingRight = true;
    private float speed = 12.0f;
    private float attackRange = 1.0f;

    void Start()
    {
        rb2D= GetComponent<Rigidbody2D>();
        spriteRenderer= GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        boss = GameObject.FindGameObjectWithTag("Boss").transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 target=new Vector2(player.position.x,rb2D.position.y);
        Vector2 newPos = Vector2.MoveTowards(rb2D.position, target, speed * Time.deltaTime);
        rb2D.MovePosition(newPos);

        if (player.position.x - boss.position.x < 0 && isFacingRight)
        {
            Flip();
            isFacingRight= false;
        }
        else if(player.position.x-boss.position.x> 0 && !isFacingRight)
        {
            Flip();
            isFacingRight= true;
        }

        if (Vector2.Distance(player.position, rb2D.position) <= attackRange)
        {
            animator.SetTrigger("Attack");
        }
        else
        {
            animator.ResetTrigger("Attack");
        }
    }

    private void Flip()
    {
        spriteRenderer.flipX= !spriteRenderer.flipX;
    }
}
