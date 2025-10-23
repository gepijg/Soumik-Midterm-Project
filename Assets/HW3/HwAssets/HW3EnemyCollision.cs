using UnityEngine;

public class HW3EnemyCollision : MonoBehaviour

{
    public GameObject otherOject;
    public Vector3 velocity = new Vector3(0.01f, 0, 0);

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        { 
            Destroy(collision.gameObject); 
       }
       

    }
    void Update()
    {
       velocity = otherOject.transform.position - transform.position;
        velocity = velocity.normalized * 0.01f;
       transform.position += velocity;

    }
}
