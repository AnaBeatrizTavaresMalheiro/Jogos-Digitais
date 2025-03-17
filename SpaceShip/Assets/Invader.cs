using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invader : MonoBehaviour{
    // Start is called before the first frame update
    private float lenght;

    public static int naoMatou = 0;
    private float movingSpeed = 1f;
    public GameObject cam;
    public static float parallaxEffect = GameManager.invaderSpeed;

    // Start is called before the first frame update
    void Start(){
        lenght = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // void OnTriggerEnter2D(Collider2D other){

    //     if (other.CompareTag("Bricks")){
    //         GameManager.notifyScore(10);
    //         Destroy(other.gameObject); // Remove a nave inimiga
    //         Destroy(gameObject);       // Remove o míssil
    //     }
    //     else if(other.CompareTag("Invaders")){
    //         GameManager.notifyScore(100);
    //         GameManager.num_invaders -= 1;
    //         Destroy(other.gameObject); // Remove a nave inimiga
    //         Destroy(gameObject);       // Remove o míssil

    //     }
        
    //     // if(GameManager.num_invaders == 0){
    //     //     naoMatou = 0;
    //     //     GameManager.notifyWinner();
    //     // }
        
    // }

    // Update is called once per frame
   void Update(){
        transform.position += Vector3.left * Time.deltaTime * movingSpeed * parallaxEffect;
        if(transform.position.x < -4.094f ) {
            Destroy(gameObject);
            naoMatou += 1;
            GameManager.num_invaders -= 1;


        }
        if(naoMatou >= 4){
            naoMatou = 0;
            GameManager.gameOver();
        }

        if(GameManager.score >= 300){
            parallaxEffect = 0.5f;
        }

        if(GameManager.num_invaders == 0){
            naoMatou = 0;
            GameManager.notifyWinner();
        }

        Debug.Log(naoMatou);

    }
}