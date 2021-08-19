using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
      public int maxHealth = 100;
      public int currentHealth;
      public  HealthBar healthBar;
    
     public GameObject deathEffect;
   
   void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }


   public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

         if(currentHealth <= 0)
        {
            Die();
        }
    }

     void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(5);
        }
       
        
        
    }

     void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


}
