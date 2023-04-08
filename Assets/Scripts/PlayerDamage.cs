using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public Vector3 attackSet;
    public float attackRange = 5.0f;
    public LayerMask attackMask;
    public float attackDamage = 500.0f;
    public void Attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackSet.x;
        pos += transform.up * attackSet.y;

        Collider2D col = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if (col != null)
        {
            col.GetComponent<BossHealth>().TakeDamage(attackDamage);
        }
    }
}
