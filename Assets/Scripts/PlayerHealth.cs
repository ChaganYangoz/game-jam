using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth=100.0f;
    void Start()
    {
        health = maxHealth;
    }

    
    public void TakeDamage(float damage)
    {
        health=health- damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    
}
