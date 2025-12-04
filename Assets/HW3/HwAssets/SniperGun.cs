using UnityEngine;
using System.Collections.Generic;

public class SniperGun : MonoBehaviour
{
    public List<GameObject> Enemy = new List<GameObject>();
    public GameObject SB;
    public GameObject Sniper;
    public int spawnAmount = 3;
    public float Timer = 1f;

    public float fireRate = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }
    public void SpawnBullet()
    {
        Instantiate(SB, Sniper.transform.position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {

        if (Timer <= 0)
        {
            Timer = fireRate;
            SpawnBullet();
        }

        Timer -= Time.deltaTime;

    }
}