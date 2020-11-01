using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Lethal : MonoBehaviour
{
    public float damage;
    public string enemytag;
    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == enemytag) 
        {
            col.gameObject.GetComponent<healthman>().TakeDamage(damage);
        }
    }
}