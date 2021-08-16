using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour
{
    public float timeBetweenSpawn;
    public GameObject prefab; //pass the coin prefab to script through inspector

    private float timeUntilNextSpawn;

    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextSpawn = timeBetweenSpawn;
    }

    void Spawn() 
    {
        for(int i = 0; i < 27; i++){
            Instantiate(prefab, new Vector2(-10 + 0.7f * i, 13),Quaternion.identity); //formula for placement when spawning
        }
    }

    // Update is called once per frame
    void Update()
    {
        /*
            60 per sec - game engine running at 60 FPS
            Time.deltaTime used to see how much time has passed since last generated
            handles performance issues if user has slow machine
        */

        timeUntilNextSpawn -= Time.deltaTime; //check time we remaing until next spawn
        if(timeUntilNextSpawn <= 0.0f)
        {
            Spawn();

            timeUntilNextSpawn = timeBetweenSpawn; // reset time.
        }    
    }
}
