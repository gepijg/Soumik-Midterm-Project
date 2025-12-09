using UnityEngine;

public class Health : MonoBehaviour
{

    public int health;
    public Color NormalC;
    
  
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        NormalC = spriteRenderer.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage()
    {
        health -= 1;
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.red;
        Invoke("NormalColor", 0.1f);
        if (health == 0)
         {
           
            Destroy(gameObject);
        }
    }

    public void NormalColor()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = NormalC;
    }
   
}
