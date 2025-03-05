using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;   
using UnityEngine;

public class enviders : MonoBehaviour
{

    private Rigidbody2D rb2d;
    private float timer = 0.0f;
    private float shootTimer = 0.0f;
    private float moveTimer = 0.0f;
    private float waitTime = 1.0f;
    private int state = 0;
    private float x;
    private float speed = 2.0f;

    public GameObject invaderBullet;

    // Start is called before the first frame update
    void Start(){
        rb2d = GetComponent<Rigidbody2D>();  
        x = transform.position.x;

        var vel = rb2d.velocity;
        vel.x = speed;
        rb2d.velocity = vel;  
    }

    // Update is called once per frame
    void Update(){
        timer += Time.deltaTime;
        moveTimer += Time.deltaTime;
        shootTimer += Time.deltaTime;

        if (timer >= waitTime){
            ChangeState();
            timer = 0.0f;
        }

        shoot();
    }

    void moveInvaders(){
        if (moveTimer >= 5) {
            moveTimer = 0.0f;  // Reseta o contador
            var pos = transform.position;
            pos.y -= 0.25f;  // Move para baixo
            transform.position = pos;
        }
    }

    void OnTriggerEnter2D(Collider2D collision){
        var pos = transform.position.y;
        if(pos <= -3.5f){
            Debug.Log("PERDEU");
            GameManager.gameOver();
        }
    }

    void shoot(){
        
        if(shootTimer >= 5.0f){
            if(Random.Range(0, 50) < 3){
                GameObject bullet = Instantiate(invaderBullet, transform.position, Quaternion.identity);
            }
            shootTimer = 0.0f;
        }
    }

    void ChangeState(){
        var vel = rb2d.velocity;
        vel.x *= -1;
        rb2d.velocity = vel;
        moveInvaders();
    }

}
