using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicBall : MonoBehaviour
{
    public float speed = 27f;
    public Rigidbody2D rb; //reference to rigidbody attached to prefab
        void Start()
    {
        rb.velocity = transform.right * speed;
    }

 
}
