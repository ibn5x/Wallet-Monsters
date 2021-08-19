using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Prefab script for implementing attack system 
public class Attack : MonoBehaviour
{
    public Transform firePoint;
    public GameObject magicBallPrefab;

    
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        Instantiate(magicBallPrefab, firePoint.position, firePoint.rotation);
    }
}
