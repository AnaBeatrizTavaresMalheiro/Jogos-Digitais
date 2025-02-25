using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BallMove : MonoBehaviour{
    private Rigidbody2D rb2d;               
    public int speed = 20;
    public bool gameStarted = false;
    public int countBricks = 16;

    public int points = 0;

    public GUISkin layout;              // Fonte do placar

    void GoBall(){
        float rand = Random.Range(0, 2);
        if(rand < 1){
            rb2d.AddForce(new Vector2(100, -80));
        } else {
            rb2d.AddForce(new Vector2(-100, -80));
        }
    }

    void OnGUI () {
        GUI.skin = layout;
        GUI.Label(new Rect(Screen.width - 150, 20, 100, 100), "Pontos: " + points);

    }


    void OnCollisionEnter2D (Collision2D coll) {
        Scene scene = SceneManager.GetActiveScene();
        if(coll.collider.CompareTag("Player") || coll.collider.CompareTag("Wall") || coll.collider.CompareTag("Brick")){
            rb2d.velocity = rb2d.velocity.normalized * speed;
        }

        if (coll.gameObject.tag == "Brick"){
            Destroy(coll.gameObject);  
            points += 100;
            countBricks--;

            if (countBricks == 0){
                if (scene.name == "Arkanoid"){
                    SceneManager.LoadScene("Arkanoid 2");
                }  
                if (scene.name == "Arkanoid 2"){
                    SceneManager.LoadScene("Ganhou");
                }   
            }
        }
    }

    void ResetBall(){
        rb2d.velocity = Vector2.zero; // Mantém a bola parada
        transform.position = Vector2.zero;
    }

    void RestartGame(){
        ResetBall();
        Invoke("GoBall", 1);
    }

    void Start(){
        rb2d = GetComponent<Rigidbody2D>(); 
        rb2d.velocity = Vector2.zero; // Mantém a bola parada ao iniciar
    }

    void Update(){
        if (!gameStarted && Input.GetKeyDown(KeyCode.Space)){
            gameStarted = true;
            GoBall(); // Só chama GoBall quando o jogo for iniciado
        }
    }
}
