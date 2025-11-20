using UnityEngine;
using System.Collections.Generic;

public class Spawner : MonoBehaviour
{
    public List<GameObject> Enemy = new List<GameObject>();
    public GameObject Enemy2;
    public GameObject Enemy3;
    public int spawnAmount = 3;
    public float Timer = 5;
    public int spawnRate = 5;
    public float xMin = -5;
    public float xMax = 5;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void SpawnRandomEnemy()
    {
        Random.Range(xMin, xMax);
        int randomeI = Random.Range(0, Enemy.Count);
        Instantiate(Enemy[randomeI],new Vector3(Random.Range(xMin, xMax), 4, 0), Quaternion.identity);
    }
    public void SpawnMultipleEnemies()
    {
        for (int i = 0; i < spawnAmount; i++)
        {
            SpawnRandomEnemy();
        }

    }
    // Update is called once per frame
    void Update()
    {
        Timer -= Time.deltaTime;
        if(Timer <= 0)
        {
            SpawnMultipleEnemies();
            Timer = spawnRate;
        }
    }
}
