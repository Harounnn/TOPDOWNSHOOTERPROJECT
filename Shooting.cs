using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject BulletPrefab;
    public Transform Firepoint;
    public float BulletForce;
    void Update() 
    {
        if (Input.GetButtonDown("Fire1"))
            Shoot();
    }
    void Shoot() 
    {
        GameObject bullet = Instantiate(BulletPrefab, Firepoint.position, Firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.up * BulletForce, ForceMode2D.Impulse);
        Destroy(bullet, 5f);
    }
}