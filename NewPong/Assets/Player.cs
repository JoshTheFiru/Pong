using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public KeyCode up; //Clase que define las teclas

    public KeyCode down; 
    // Start is called before the first frame update

    float speed; 

    void Start()
    {
        speed = 0.15f; 
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(up)){
            transform.Translate(0, speed, 0);
        }

        if(Input.GetKey(down)){
            transform.Translate(0, -speed, 0);
        }
        
    }
}
