using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public KeyCode rigthArrow = KeyCode.RightArrow;      // direita
    public KeyCode leftArrow = KeyCode.LeftArrow;    // esquerda

    public KeyCode jump = KeyCode.W;

    public float speed = 40.0f;             // Define a velocidade 
    public float boundRigth = 16.46f;            // Define os limites na direita
    public float boundLeft = -14.08f;            // Define os limites na esquerda
    private Rigidbody2D rb2d;               // Define o corpo rigido 2D que representa a raquete

    private Animator animator;  

    private int movendoHash = Animator.StringToHash("Movendo");

    private int SubindoEscadaHash = Animator.StringToHash("SubindoEscada");

    private SpriteRenderer spriteRenderer; // Se o personagem estiver para a direita, o sprite é o normal, se estiver para a esquerda, o sprite é o invertido

    public Tiro projectilPrefab;
    public Transform firePoint;

    public float forca = 5.0f;

    public bool chao = false;
    
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();     // Inicializa a raquete
        animator = GetComponent<Animator>(); // Inicializa o animator
        spriteRenderer = GetComponent<SpriteRenderer>(); // Inicializa o sprite renderer
    }

    void OnCollisionEnter2D(Collision2D collision){
        Debug.Log(chao);
        if(collision.gameObject.tag == "Chao"){
            chao = true;
        }
    }

    // Update is called once per frame
    void Update(){
        var vel = rb2d.velocity;
    //    var pos = transform.position;
        
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


        if(Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectilPrefab, firePoint.position, firePoint.rotation);
        }

        if(Input.GetKey(jump) && chao){
            rb2d.AddForce(transform.up * forca);
            chao = false;
        }

        rb2d.velocity = vel;
    //   transform.position = pos;

        animator.SetBool( movendoHash, vel.x != 0);
        animator.SetBool( SubindoEscadaHash, vel.y != 0);

        if(vel.x > 0){
            spriteRenderer.flipX = false; // Se o personagem estiver se movendo para a direita, o sprite é o normal
        } else if (vel.x < 0){
            spriteRenderer.flipX = true; // Se o personagem estiver se movendo para a esquerda, o sprite é o invertido
        }
    }
}