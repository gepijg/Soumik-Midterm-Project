using UnityEngine;

public class Hitbox : MonoBehaviour
{

public GameObject sdaebefrtbb;
    public string targettag; 
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        
    
    }
       private void OnTriggerEnter2D(Collider2D other)
    {

        //This checks to see if the thing you bumped into had the Hazard tag
        //If it does...
        
        if (other.gameObject.CompareTag(targettag))
        {
           
            // if (health <= 0)
            // {
            //     Destroy(other.gameObject);
            //}
            if(other.gameObject.TryGetComponent<Health>(out Health health))
            {
                health.TakeDamage();
            }
           
        }
    }

    //This function updates the game's score text to show how many points you have
    //Even if your 'score' variable goes up, if you don't update the text the player doesn't know
   
        

    //If this function is called, the player character dies. The player character is destroyed.
   
    // Update is called once per frame
    void Update()
    {
        
    }
}
