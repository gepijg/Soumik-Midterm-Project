using UnityEngine;

public class Health : MonoBehaviour
{

    public int health; 
    
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        health -= 1;
        if (health == 0)
         {
             Destroy(gameObject);
        }
    }
   
}
