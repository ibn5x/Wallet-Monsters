using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    public Transform[] m_SpawnPoints; //stores spawn point locations in an array
    public GameObject m_EnemyPrefab; //stores the NPC prefab
   
  
    void Start()
    {
        SpawnNewEnemy();
    }

     void OnEnable()
    {
        Enemy.OnEnemyKilled += SpawnNewEnemy; //listen for event on event trigger function
    }
    void SpawnNewEnemy()
    {
        int randomNumber = Mathf.RoundToInt(Random.Range(0f, m_SpawnPoints.Length-1)); 
        Instantiate(m_EnemyPrefab, m_SpawnPoints[randomNumber].transform.position, Quaternion.identity); //instantiate enemy NPC prefab, enter position (spawn point), then quatern for 
        
    }

    

}
