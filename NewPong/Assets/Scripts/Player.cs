using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public KeyCode up; //Clase que define las teclas

    public KeyCode down; 
    // Start is called before the first frame update

    float speed;
    float finalSpeed;  

    public AudioClip boingSound; 
    AudioSource fuenteAudio; 


    void Start()
    {
        speed = 0.15f; 
        fuenteAudio = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(up)){
            if(transform.localPosition.y > 4){
               finalSpeed = 0;  
            }else{
                finalSpeed = speed; 
            }

            transform.Translate(0, finalSpeed, 0);
        }

        if(Input.GetKey(down)){
            if(transform.localPosition.y < -4){
               finalSpeed = 0;  
            }else{
                finalSpeed = speed; 
            }
            
            transform.Translate(0, -finalSpeed, 0);
        }
        
    }

    void OnCollisionEnter(Collision objeto){
        fuenteAudio.clip = boingSound; 
        fuenteAudio.Play();
    }
}
