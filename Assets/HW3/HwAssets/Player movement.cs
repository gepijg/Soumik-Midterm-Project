using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public float speed = 0.01f;
    Vector2 velocity;
    float gravity;
    float friction;
  

    // Update is called once per frame
    void Update()
    {
     
    Vector3 currentPosition = new Vector3(transform.position.x,transform.position.y,transform.position.z);
    if (Input.GetKey(KeyCode.D)) {
        transform.position += new Vector3(1,0,0) * speed;
    }
     if(Input.GetKey(KeyCode.A)){
        transform.position += new Vector3(-1,0,0) * speed;
    }
        if (Input.GetKey(KeyCode.Space))
        {
            transform.position += new Vector3(0, 5, 0) * speed;
        }

         if (transform.position.y > 5 )
        {
         transform.position = new Vector3(transform.position.x, -5, transform.position.z) * speed;
         }


    }
}
