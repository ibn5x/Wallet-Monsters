using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed; 
    private Rigidbody2D rb;
    private float moveInput;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal"); //-1  move left | 0 stand still | 1 move right
        rb.velocity = new Vector2(moveInput*speed, rb.velocity.y);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
