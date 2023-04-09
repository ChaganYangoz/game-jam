using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public GameObject bar;
    public float health;
    public float maxHealth = 100.0f;
    public HealthBar healthBar;
    private Animator anim;
    private SpriteRenderer renderer;
    private bool once=true;
    void Start()
    {
        health = maxHealth;
        healthBar.Health(health);
        anim = GetComponent<Animator>();
        renderer = GetComponent<SpriteRenderer>();
    }

    public void TakeDamage(float damage)
    {
        health = health - damage;
        healthBar.Health(health);
        StartCoroutine(forColorRed());
        if (health<maxHealth/2 && once)
        {
            anim.SetTrigger("RageState");
            healthBar.Health(health+maxHealth/4);
            health=health+maxHealth/4;
            once= false;
        }
        if (health <= 0)
        {
            Destroy(gameObject);
            Destroy(bar);
        }
    }

    IEnumerator forColorRed()
    {
        renderer.material.color = Color.red;
        yield return new WaitForSecondsRealtime(0.3f);
        renderer.material.color = Color.white;
    }
}
