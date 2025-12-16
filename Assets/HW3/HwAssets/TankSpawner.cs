using UnityEngine;
using System.Collections.Generic;

public class TankSpawner : MonoBehaviour
{
    public List<GameObject> Enemy = new List<GameObject>();
    public GameObject Tank;
    public int spawnAmount = 3;
    public float Timer = 5;
    public float NTimer = 7;
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
        Instantiate(Enemy[randomeI], new Vector3(Random.Range(xMin, xMax), 8, 0), Quaternion.identity);
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
        if (Timer <= 0)
        {
            SpawnMultipleEnemies();
            Timer = 10;
        }
    }
}