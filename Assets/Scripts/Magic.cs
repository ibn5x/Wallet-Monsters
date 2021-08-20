using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Raycasting script for implementing attack
public class Magic : MonoBehaviour
{
    public Transform firePoint;
    public int damage = 2;
   

    public GameObject impactEffect; 
    public LineRenderer lineRenderer; 

   
   

        void Update()
    {
        if(Input.GetButtonDown("Fire1")) 
        {
           StartCoroutine(Shoot());
            SoundManagerScript.PlaySound("playerAttack");
        }
    }
        IEnumerator Shoot()
        {
          RaycastHit2D hitInfo = Physics2D.Raycast(firePoint.position, firePoint.right);

          if(hitInfo)
          {
             
             Enemy enemy = hitInfo.transform.GetComponent<Enemy>();

             if(enemy != null)
           {
              SoundManagerScript.PlaySound("playerImpact");
              enemy.TakeSomeDamage(damage);
           }

             Instantiate(impactEffect, hitInfo.point, Quaternion.identity);    

             lineRenderer.SetPosition(0, firePoint.position); //point of origin 
             lineRenderer.SetPosition(1, hitInfo.point); //origin destination 
          }else
          {
              lineRenderer.SetPosition(0, firePoint.position); //point of origin 
              lineRenderer.SetPosition(1, firePoint.position + firePoint.right * 100); //origin destination (continuous)
          }

          lineRenderer.enabled = true; //turn on line renderer

            //wait a set ms
            yield return new WaitForSeconds(0.02f);   //new 0.02f; 

          lineRenderer.enabled = false; //turn it off  
    }
}
