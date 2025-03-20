using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public KeyCode rigthArrow = KeyCode.RightArrow;      // direita
    public KeyCode leftArrow = KeyCode.LeftArrow;    // esquerda
    public float speed = 40.0f;             // Define a velocidade 
    public float boundRigth = 16.46f;            // Define os limites na direita
    public float boundLeft = -14.08f;            // Define os limites na esquerda
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete


    
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();     // Inicializa a raquete
       
    }

    // Update is called once per frame
    void Update(){
        var vel = rb2d.velocity;
        var pos = transform.position;
        
        //Deslocar objeto
        if (Input.GetKey(leftArrow)){
            vel.x = - speed;
        }
        else if (Input.GetKey(rigthArrow)){
            vel.x = speed;
        }
        else {
            vel.x = 0;                          // Velociade para manter parada
        }
        rb2d.velocity = vel;
        transform.position = pos;
    }
}
