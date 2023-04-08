using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public float health;
    public float maxHealth = 100.0f;
    public HealthBar healthBar;
    void Start()
    {
        health = maxHealth;
        healthBar.Health(health);
    }


    public void TakeDamage(float damage)
    {
        health = health - damage;
        healthBar.Health(health);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
