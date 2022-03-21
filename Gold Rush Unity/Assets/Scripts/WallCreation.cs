using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallCreation : MonoBehaviour
{
    public GameObject wall;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(wall, new Vector3(transform.position.x+2,transform.position.y,5), Quaternion.identity);   
        Instantiate(wall, new Vector3(transform.position.x-2,transform.position.y,5), Quaternion.identity);  
        Instantiate(wall, new Vector3(transform.position.x,transform.position.y+2,5), Quaternion.identity);   
        Instantiate(wall, new Vector3(transform.position.x,transform.position.y-2,5), Quaternion.identity);  
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
