using UnityEngine;
using System.Collections.Generic;

public class Gun : MonoBehaviour
{
    public List<GameObject> Enemy = new List<GameObject>();
    public GameObject Bullet;
    public GameObject Player;
    public int spawnAmount = 3;
    public float Timer = 1f;
    
   
    public float fireRate  = 1f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public void SpawnBullet(){
      Instantiate(Bullet,Player.transform.position,Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
   
    if(Timer <= 0) {
        Timer = fireRate;
      SpawnBullet();
    }
   
      Timer -= Time.deltaTime;
      
    }
}
