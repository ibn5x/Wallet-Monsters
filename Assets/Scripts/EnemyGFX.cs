using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;

    
    void OnCollisionEnter2D(Collision2D other)
    {
         if(other.gameObject.CompareTag("Coin"))
        {
           

           Destroy(other.gameObject);    
           SoundManagerScript.PlaySound("coinCollect");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(aiPath.desiredVelocity.x >= 0.01f){

            transform.localScale = new Vector3(1f, 1f, 1f); 

        }else if(aiPath.desiredVelocity.x <= -0.01f){
       
         transform.localScale = new Vector3(-1f, 1f, 1f); 
        }
    }
}
