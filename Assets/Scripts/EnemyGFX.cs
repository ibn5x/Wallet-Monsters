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
           SoundManagerScript.PlaySound("coinCollect");

           Destroy(other.gameObject);    
           
        }else if(other.gameObject.CompareTag("Enjimon"))
        {
            SoundManagerScript.PlaySound("npcImpact");
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
