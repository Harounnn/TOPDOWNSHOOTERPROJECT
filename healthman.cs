using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthman : MonoBehaviour
{
    public float health;
    public Behaviour[] disableOnDeath;
    public void Start()
    {
        health = Random.Range(60f, 120f);
    }
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0)
        {
            health = 0;
            Die();
        }
    }
    void Die()
    {
        foreach (Behaviour behaviour in disableOnDeath)
        {
            behaviour.enabled = false;
        }
    }
}
