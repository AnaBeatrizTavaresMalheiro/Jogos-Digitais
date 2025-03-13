using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public KeyCode upArrow = KeyCode.UpArrow;      
    public KeyCode downArrow = KeyCode.DownArrow;    
    public float speed = 20.0f;             // Define a velocidade 
    public float boundTop = 3.63f;            // Define os limites na direita
    public float boundBottom = -3.63f;            // Define os limites na esquerda
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete

    public Transform firePoint;
    
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();     // Inicializa a raquete
       
    }

    // Update is called once per frame
    void Update(){
        var vel = rb2d.velocity;
        var pos = transform.position;

        
        
        //Deslocar objeto
        if (Input.GetKey(upArrow)){
            vel.y = speed;
        }
        else if (Input.GetKey(downArrow)){
            vel.y = -speed;
        }
        else {
            vel.y = 0;                          // Velociade para manter parada
        }
        rb2d.velocity = vel;

        
        if (pos.y > boundTop){
            pos.y = boundTop;
        }
        else if (pos.y < boundBottom){
            pos.y = boundBottom;
        }
        transform.position = pos;
    }
}

