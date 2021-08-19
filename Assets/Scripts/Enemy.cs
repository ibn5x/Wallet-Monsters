using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
   //public int health = 100;

    public int totalHealth = 100;
    public int healthNow;
    public  HealthBar enemyHealthBar;

    public GameObject deathEffect;
    
     void Start()
    {
        healthNow = totalHealth;
        enemyHealthBar.SetMaxHealth(totalHealth);
    }

    public void TakeSomeDamage (int damage)
    {
         healthNow -= damage;

         enemyHealthBar.SetHealth(healthNow);

        if(healthNow <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}
