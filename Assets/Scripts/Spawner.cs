using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] objects;                // The prefab to be spawned.
    public float spawnTime = 6f;            // How long between each spawn.
    private Vector3 spawnPosition;

    public int score;

    private void Update()
    {
        
    }

    // Use this for initialization
    void Start()
    {
        // Call the Spawn function after a delay of the spawnTime and then continue to call after the same amount of time.
        InvokeRepeating("Spawn", spawnTime, spawnTime);

    }


    void Spawn()
    {
        
        //Determine the position of where the enemy spawns
        spawnPosition.x = Random.Range(-40, 60);
        spawnPosition.y = 0.5f;
        spawnPosition.z = Random.Range(-40, 60);

        Instantiate(objects[UnityEngine.Random.Range(0, objects.Length - 1)], spawnPosition, Quaternion.identity);
    }
}
