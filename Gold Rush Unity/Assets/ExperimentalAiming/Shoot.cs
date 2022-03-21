using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0)&&Player.ammo>0){
                        Instantiate(bullet, new Vector3(transform.position.x,transform.position.y,2), Quaternion.identity);  
        }
    }
}
