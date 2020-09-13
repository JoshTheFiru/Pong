using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{

    int speedX; 
    int speedY; 

    float speed;
    int player1Score; 
    int player2Score; 

    //Puntuación
    public Text scoreText; 

    //Ganador
    public Text winner; 
    
    //Partículas
    public ParticleSystem sparks;

    // Start is called before the first frame update
    void Start(){

        MoveBall();
    }


    // Update is called once per frame
    void Update()
    {
        scoreText.text = player1Score.ToString() + " - " + player2Score.ToString();  

        if(player1Score == 2){
            winner.text = "Player 1 Gana";
            winner.gameObject.SetActive(true);
            ResetBall();

        }else if(player2Score == 2){
            winner.text = "Player 2 Gana";
            winner.gameObject.SetActive(true);
            ResetBall();
        }
    }

    void OnCollisionEnter(Collision objeto){
        if(objeto.collider.tag == "player1Goal"){
            player1Score++;
            ResetBall();
            Invoke("MoveBall", 2);

        }else if(objeto.collider.tag == "player2Goal"){
            player2Score++;
            ResetBall();
            Invoke("MoveBall", 2);

        }else if(objeto.collider.tag == "Player"){
            sparks.Play();
        }
    }

    void ResetBall(){
        transform.localPosition = Vector3.zero; 
        GetComponent<Rigidbody>().velocity = Vector3.zero; 
    }

    void MoveBall(){
        speed = Random.Range(5, 10);

        speedX = Random.Range(0, 2);
        if(speedX == 0){
            speedX = 1; 
        }else{
            speedX = -1;
        }

        speedY = Random.Range(0, 2); 
        if (speedY == 0){
            speedY = 1;
        }else{
            speedY = -1; 
        }

        GetComponent<Rigidbody>().velocity = new Vector3(speed * speedX, speed * speedY, 0);

    }
}
