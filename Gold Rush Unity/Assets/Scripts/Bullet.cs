using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float xaim = 0;
    float yaim = 0;
    float life = 1;
    // Start is called before the first frame update
    void Start()
    {
    xaim=Target.x-Aim.x;
    yaim=Target.y-Aim.y;    
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + new Vector3(xaim*Time.deltaTime*5, yaim* Time.deltaTime*5, 0);
        life-=(1*Time.deltaTime);
        if(life<=0){
            Destroy(gameObject);
        }
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
