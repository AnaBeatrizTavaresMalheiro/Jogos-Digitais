using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Escada : MonoBehaviour
{
    // Start is called before the first frame update

    public KeyCode upArrow = KeyCode.UpArrow;      // direita

    private float speed = 8f;

    private bool escada = false;

    private bool escalando = false;

    public Rigidbody2D playerRb;

    void OnTriggerEnter2D(Collider2D collision){ //subir escada
        if(collision.CompareTag("Escada")){
            escada = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision){ //saiu da escada
        
        if(collision.CompareTag("Escada")){
            escada = false;
            escalando = false;
        }
    }

    void FixedUpdate(){
        if(escalando == true){ //tira a gravidade
            playerRb.gravityScale = 0f; //tira a gravidade
            playerRb.velocity = new Vector2(playerRb.velocity.x , speed); 
        } else {
            playerRb.gravityScale = 20.0f; //coloca a gravidade de volta
        }
    }

    void Start(){
        
    }


    void Update(){
        if(escada && Input.GetKey(upArrow)){
            escalando = true;
        } else {
            escalando = false;
        }

        if(escalando){
            playerRb.velocity = new Vector2(playerRb.velocity.x, speed); //subir escada
        } else {
            playerRb.velocity = new Vector2(playerRb.velocity.x, 0); //parar de subir escada
        }
    }
    
}
