using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadGuy : MonoBehaviour
{
    public float x;
    public float y;
    public int speed = 2;
    public int health = 5;
    private int hCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(Player.x,Player.y,1);
    }

    // Update is called once per frame
    void Update()
    {
        x = transform.position.x;
        y = transform.position.y;
	Vector2 pPos = new Vector2(Player.x,Player.y);
        transform.position = Vector2.MoveTowards(transform.position, pPos, speed * Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            health -= 1;
            if(health==0)
                Destroy(gameObject);
            Destroy(other.gameObject);
        }
        if( other.gameObject.tag == "Player" ){
            hCount = 50;
        }
    }
    void OnCollisionStay2D(Collision2D other){
        if (other.gameObject.tag == "Player"){
	    hCount -= 1;
            if(hCount == 0){
                Player.damageSelf(1);
                hCount = 50;
            }
        }
    }
}
