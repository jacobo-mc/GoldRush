using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AmmoCount : MonoBehaviour
{        
        [SerializeField] 
        private Text txt;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Text>().color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        txt.text = "Ammo: "+Player.ammo+"\nHealth: "+Player.health;
    }
}
