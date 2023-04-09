using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFight : MonoBehaviour
{
    public Transform attackPos;
    public LayerMask enemy;
    public float attackRange;
    public float damage = 20.0f;
    void Update()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            Collider2D[] enemiestoDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, enemy);
            for(int i=0;i<enemiestoDamage.Length;i++)
            {
                enemiestoDamage[i].GetComponent<BossHealth>().TakeDamage(damage);
            }
        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }
}
