using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    public List<GameObject> Enemy = new List<GameObject>();
    public GameObject Small;
   
    /// <summary>
    /// A list
    /// 
    /// </summary>
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Spawn()
    {
        Instantiate(Small, Small.transform.position, Quaternion.identity);
    }
}
 