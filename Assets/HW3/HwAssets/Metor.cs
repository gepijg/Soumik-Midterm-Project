using UnityEngine;

public class Metor : MonoBehaviour
{

    public float Timer = 7;
    
    
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
          Timer -= Time.deltaTime;
        if (Timer <= 0)
         {
             Timer = 7;
            Destroy(gameObject);
        }
    }

   

}
