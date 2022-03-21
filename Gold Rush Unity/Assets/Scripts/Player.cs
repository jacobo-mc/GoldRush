using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public static float x;
    public static float y;
    public static int ammo = 20;
    public static int Speed = 5;
    public static int health = 20;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start(){
        rb = gameObject.GetComponent<Rigidbody2D>();    
    }

    // Update is called once per frame
    void Update(){
        x = transform.position.x;
        y = transform.position.y;
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3 (0, 0, angle);

        var targetPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        targetPos.z = transform.position.z;
        x = transform.position.x;
        y = transform.position.y;
        if (Input.GetKey(KeyCode.Mouse1)){
            transform.position = Vector2.MoveTowards(transform.position, targetPos, Speed * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Mouse0)&&ammo>0){
            ammo=ammo-1;
        }
    }
    public static void damageSelf(int amount){
        if(health>0){
            health -= amount;
        }
        if(health<=0){
            health=1;
        }
    }
    public static void reammoSelf(int amount){
        if(health>0){
            ammo += amount;
        }
    }
    public static void healSelf(int amount){
        health += amount;
    }
}
