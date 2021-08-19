using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Raycasting script for implementing attack
public class Magic : MonoBehaviour
{
    public Transform firePoint;
    public int damage = 2;

    public GameObject impactEffect; 

   
   

        void Update()
    {
        if(Input.GetButtonDown("Fire1")) 
        {
            Shoot();
        }
    }
        void Shoot()
        {
          RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

          if(hitInfo)
          {
             
             Enemy enemy = hitInfo.transform.GetComponent<Enemy>();

             if(enemy != null)
           {
              enemy.TakeSomeDamage(damage);
           }

             Instantiate(impactEffect, hitInfo.point, Quaternion.identity);
             
          }
        
    }
}
