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
            Debug.Log("Timer is up Bro. Mikal.");
            timeUntilNextSpawn = timeBetweenSpawn; // reset time.
        }    
    }
}
