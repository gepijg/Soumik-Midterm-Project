using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float increaseValue = 20f;
    public float rotationValue = 20f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float rotation = rotationValue += increaseValue;
        transform.rotation = Quaternion.Euler(0, 0, rotation);
    }
}
