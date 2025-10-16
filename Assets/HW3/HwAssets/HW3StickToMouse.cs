using UnityEngine;

public class HW3StickToMouse : MonoBehaviour 
{
    public float speed = 0.01f;
   
  

    // Update is called once per frame
    void Update()
    {
     

      

        Vector2 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = mouseWorldPosition;
    }
}
