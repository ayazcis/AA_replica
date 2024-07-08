using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinSpawner : MonoBehaviour
{
    public GameObject PinPrefab;
    private float latestSpawnTime = 0;
    public float spawnDelay = 2f;



    void Update()
    {
        if (Input.GetButtonDown("Fire1") && latestSpawnTime + spawnDelay < Time.timeSinceLevelLoad)
        {
            Spawn(PinPrefab);
            latestSpawnTime = Time.timeSinceLevelLoad;
        }
    }
    void Spawn(GameObject pinPrefab)
    {
        Instantiate(pinPrefab,transform.position,transform.rotation);
    }
    
}
