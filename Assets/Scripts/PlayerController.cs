using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool facedRight;
    
    public float horizontalValue;
    public float speed; 

    public float jumpsAllowed;
    private float jumpedAmount;

    public float jumpForce;
    private Rigidbody2D rb;
    private float moveInput;
    private float jumpInput;
    private float previousJumpInput;

   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        previousJumpInput = 0;
        
    }

    void FixedUpdate()
    {
        moveInput = Input.GetAxis("Horizontal"); //-1  move left | 0 stand still | 1 move right
        rb.velocity = new Vector2(moveInput*speed, rb.velocity.y);    

        jumpInput = Input.GetAxis("Vertical"); //-1 move down | 0 nothing | 1 move up
        if(jumpInput > 0 && jumpedAmount < jumpsAllowed && previousJumpInput == 0)
            {
               SoundManagerScript.PlaySound("playerJump");
                
               rb.velocity = new Vector2(rb.velocity.x, jumpForce);
               
               jumpedAmount++;
            } 
        previousJumpInput = jumpInput; //after we finish set it to current input value.
    }

//will be called as soon as Enjimon collides with "other" ensure its ground or what were detecting
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Ground"))
        {
            jumpedAmount = 0; //enjimon touched ground reset count.
        }
        else if(other.gameObject.CompareTag("Coin"))
        {
           SoundManagerScript.PlaySound("coinCollect");

           Destroy(other.gameObject); //enjimon touched coin, built in function removes them.
           
           TextManager.instance.IncreaseScore(); //accessing static instance and calling function to increase score
        }
    }

    void Move() 
    {
        horizontalValue = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
    }

    void ProperFlip() 
    {
        if((horizontalValue < 0 && facedRight) || (horizontalValue > 0 && !facedRight))
        {
            facedRight = !facedRight;
            transform.Rotate(new Vector3(0, 180, 0));
        }
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        ProperFlip();
    }
}
