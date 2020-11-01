using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieSpawner : MonoBehaviour
{
    public GameObject ZombiePrefab;
    Vector3 RandomCirle(Vector3 center , float radius) 
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }
    void Spawn() 
    {
        Vector2 position = RandomCirle(Vector3.zero, 20);
        Instantiate(ZombiePrefab, position, Quaternion.identity);
    }
    void Start()
    {
        float spawnrate = Random.RandomRange(1f, 5f);
        InvokeRepeating("Spawn", .5f, spawnrate++);
    }
}