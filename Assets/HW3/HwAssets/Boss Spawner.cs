using UnityEngine;
using System.Collections.Generic;

public class BossSpawner : MonoBehaviour
{
    public List<GameObject> Enemy = new List<GameObject>();
    public GameObject Small;
    public int spawnAmount = 1;
    public float Timer = 7;
    public int spawnRate = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void SpawnRandomEnemy()
    {
     
        int randomeI = Random.Range(0, Enemy.Count);
        Instantiate(Enemy[randomeI],new Vector3(0, 4, 0), Quaternion.identity);
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
            Timer = 30;
        }
    }
}