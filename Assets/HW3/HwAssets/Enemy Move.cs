using UnityEngine;

public class EnemyMove : MonoBehaviour
{
public GameObject Player;
    public float speed = 5;
public Vector3 velocity = new Vector3(0.01f, 0, 0);
public SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
private void OnTriggerEnter2D(Collider2D collision){

}
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        
        Player = FindFirstObjectByType<PlayerMovement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        velocity = Player.transform.position - transform.position;
        velocity = velocity.normalized * speed * Time.deltaTime;
        transform.position += velocity;
    }
}
