using UnityEngine;

public class PlayerMovement : MonoBehaviour 
{
    public float speed = 0.01f;
   
  

    // Update is called once per frame
    void Update()
    {
     
    Vector3 currentPosition = new Vector3(transform.position.x,transform.position.y,transform.position.z);
    if (Input.GetKey(KeyCode.D)) {
        transform.position += new Vector3(1,0,0) * speed;
    }
     if(Input.GetKey(KeyCode.S)) {
        transform.position += new Vector3(0,-1,0) * speed;
    }
     if(Input.GetKey(KeyCode.W)){
        transform.position += new Vector3(0,1,0) * speed;
    }
     if(Input.GetKey(KeyCode.A)){
        transform.position += new Vector3(-1,0,0) * speed;
    }
      

      
    }
}
