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
        
    }
}
