using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoBox : MonoBehaviour
{
    public float x;
    public float y;
    public int amount = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	transform.position = new Vector2(x,y);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player"){
            Player.reammoSelf(amount);
            Destroy(gameObject);
        }
    }
}
