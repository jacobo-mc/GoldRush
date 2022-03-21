using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class RandomTypeA : MonoBehaviour
{
    public GameObject block;
        public GameObject warp;
    int tiles = 0;
    int direction = 0;
    int olddirection=0;
    
    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
       while(tiles<1000){
            Instantiate(block, new Vector3(transform.position.x,transform.position.y,5), Quaternion.identity);   
           while(direction==olddirection||(direction==1&&transform.position.x>=24)||(direction==2&&transform.position.x<=-24)||(direction==4&&transform.position.y>=24)||(direction==3&&transform.position.y<=-24)){
            direction = Random.Range(1, 5);
            }
            olddirection=direction;
                if(direction==1){
                    transform.position = new Vector3 (transform.position.x+2, transform.position.y, 5);
                }
                if(direction==2){
                    transform.position = new Vector3 (transform.position.x-2, transform.position.y, 5);
                }
                if(direction==3){
                    transform.position = new Vector3 (transform.position.x, transform.position.y-2, 5);     
                }
                if(direction==4){
                    transform.position = new Vector3 (transform.position.x,transform.position.y+2, 5); 
                }

                    
            tiles=tiles+1;         
        }  
            Instantiate(warp, new Vector3(transform.position.x,transform.position.y,-2), Quaternion.identity); 
            Destroy (gameObject);
    }
}
