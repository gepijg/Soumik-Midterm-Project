using UnityEngine;

public class Jump : MonoBehaviour
{
public float speed = 0.01f;
    public float jumpSpeed = 10;
    public Rigidbody2D rb;
    public bool canJump = true;
    Vector2 velocity;
    float gravity;
    float friction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKey(KeyCode.Space)) {
         //     rb.linearVelocity = new Vector2(0, jumpSpeed);
        // }

    }
   // void OnCollisionEnter2D(Collision2D collision)
   // {
     //   if (collision.gameObject.CompareTag("Ground"))
      //  {
        //    canJump = true;
       // }
   // }
}
