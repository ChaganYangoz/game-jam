using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Boss : MonoBehaviour
{
    private Rigidbody2D rb2D;
    private SpriteRenderer spriteRenderer;
    Transform player;
    Transform boss;
    private bool isFacingRight = true;
    void Start()
    {
        rb2D= GetComponent<Rigidbody2D>();
        spriteRenderer= GetComponent<SpriteRenderer>();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        boss = GameObject.FindGameObjectWithTag("Boss").transform;
    }

    // Update is called once per frame
    void Update()
    {
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
        
    }

    private void Flip()
    {
        spriteRenderer.flipX= !spriteRenderer.flipX;
    }
}
