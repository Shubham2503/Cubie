using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSpawner : MonoBehaviour {

    public GameObject spawns;
    public Transform[] spawnSpots;
    private float timeBtwSpawns;
    public int tm = 0;
    public float startTimeBtwSpawns;


    void Start()
    {
        timeBtwSpawns = startTimeBtwSpawns;
    }


    void Update()
    {
        if (timeBtwSpawns <= 0)
        {
            if (tm <= 10)
            {
                int randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                tm++;
            }
            if (tm <= 30 && tm > 10)
            {
                int randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                tm++;
            }
            if (tm <= 60 && tm > 30)
            {
                int randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                tm++;
            }
            if (tm > 60 && tm <= 100)
            {
                int randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                tm++;
            }
            if (tm >= 100)
            {
                int randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                randPos = Random.Range(0, spawnSpots.Length);
                Instantiate(spawns, spawnSpots[randPos].position, Quaternion.identity);
                timeBtwSpawns = startTimeBtwSpawns;
                tm++;
            }
        }
        else
        {
            timeBtwSpawns -= Time.deltaTime;
        }
    }
}
