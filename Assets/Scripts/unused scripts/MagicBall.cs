using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Prefab script for implementing attack system for magic ball
public class MagicBall : MonoBehaviour
{
    public float speed = 27f;
    public Rigidbody2D rb; //reference to rigidbody attached to prefab
        void Start()
    {
        rb.velocity = transform.right * speed;
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Debug.Log(hitInfo.name);
        Destroy(gameObject);
    }
}
