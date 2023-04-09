using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour
{
    public Vector3 attackSet;
    public float attackRange = 4.0f;
    public LayerMask attackMask;
    public float attackDamage = 20.0f;
    public void Attack()
    {
        Vector3 pos = transform.position;
        pos += transform.right * attackSet.x;
        pos += transform.up * attackSet.y;

        Collider2D collider = Physics2D.OverlapCircle(pos, attackRange, attackMask);
        if (collider != null)
        {
            Debug.Log("vurdu");
            collider.GetComponent<BossHealth>().TakeDamage(attackDamage);
        }
    }
}
