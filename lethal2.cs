using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lethal2 : MonoBehaviour
{
    public float damage;
    public string enemytag;
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == enemytag)
        {
            col.gameObject.GetComponent<HealthManager>().TakeDamage(damage);
        }
    }
}