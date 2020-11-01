using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthManager : MonoBehaviour
{
    public float health = 100f;
    public Behaviour[] disableOnDeath;
    public Image healthbar;
    public GameObject button;
    public GameObject button1;
    public void TakeDamage(float amount) 
    {
        health -= amount;
        if (health <= 0) 
        {
            health = 0;
            Die();
        }
        healthbar.fillAmount = health / 100;
    }
    void Die() 
    {
        foreach(Behaviour behaviour in disableOnDeath) 
        {
            behaviour.enabled = false;
        }
        button.SetActive(true);
        button1.SetActive(true);
    }
}