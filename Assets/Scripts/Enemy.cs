using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{
   //public int health = 100;

    public int totalHealth = 100;
    public int healthNow;
    public  HealthBar enemyHealthBar;

    public delegate void EnemyKilled(); //defined
    public static event EnemyKilled OnEnemyKilled; //emmit event on...


    public GameObject deathEffect;

    public GameObject prefab;
    public GameObject prefabGrouped;
    
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
        SoundManagerScript.PlaySound("playerVaporized");
        Instantiate(deathEffect, transform.position, Quaternion.identity);
        
        prefabGrouped.transform.position = new Vector3(100 * 1000, 100 * 1000, 1);
        if(OnEnemyKilled != null)
        {
            
            OnEnemyKilled();
          
          
            
        }
        
       
       
    }

    void Spawn()
    {
       // Instantiate(prefab, new Vector3(100, 100, 1),Quaternion.identity); //formula for placement when spawning
        healthNow = totalHealth;
        enemyHealthBar.SetMaxHealth(totalHealth);
        Debug.Log("Respawn NPC!"); 
    }

}
