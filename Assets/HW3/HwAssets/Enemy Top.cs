using UnityEngine;

public class EnemysMovement : MonoBehaviour
{
    public float speed = 0.01f;
    public bool movingRight = true;
    public float away = 0f;
    public float reverse = 4f;
    public float breverse = -4f;
    public GameObject otherObject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (movingRight)
        {
            transform.position += new Vector3(1, 0, 0) * speed;
            away += speed;
        }
        else
        {
            transform.position += new Vector3(-1, 0, 0) * speed;
            away -= speed;
        }
        if (away > reverse)
        {
            movingRight = false;
        }
        if (away < breverse)
        {
            movingRight = true;
        }
    }
}
