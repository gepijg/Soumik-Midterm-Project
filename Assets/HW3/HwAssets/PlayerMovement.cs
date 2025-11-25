using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public float speed = 5f;
  
    Vector2 velocity;
    float gravity;
    float friction;
   public GameObject otherOject;
    void Start() {
        
    }
     private void OnCollisionEnter2D(Collision2D other)
    {
        //This checks to see if the thing you bumped into had the Hazard tag
        //If it does...
        if (other.gameObject.CompareTag("Hazard"))
        {
            //Run your 'you lose' function!
            Die();
        }
    }

    //This function updates the game's score text to show how many points you have
    //Even if your 'score' variable goes up, if you don't update the text the player doesn't know
   
        

    //If this function is called, the player character dies. The player character is destroyed.
    public void Die()
    {
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = new Vector3(transform.position.x,transform.position.y,transform.position.z);
        if (Input.GetKey(KeyCode.D)) {
            transform.position += new Vector3(1,0,0) * speed* Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.A)){
            transform.position += new Vector3(-1,0,0) * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.W)){
            transform.position += new Vector3(0,1,0) * speed * Time.deltaTime;
        }
        if(Input.GetKey(KeyCode.S)){
            transform.position += new Vector3(0,-1,0) * speed * Time.deltaTime;
        }
       
    }
}
