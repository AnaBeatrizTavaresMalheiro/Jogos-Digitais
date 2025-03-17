using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectil : MonoBehaviour{
    public float speed = 5f;

    void Update(){
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){

        if (other.CompareTag("Bricks")){
            GameManager.notifyScore(10);
            Destroy(other.gameObject); // Remove a nave inimiga
            Destroy(gameObject);       // Remove o míssil
        }
        else if(other.CompareTag("Invaders")){
            GameManager.notifyScore(100);
            GameManager.num_invaders -= 1;
            Destroy(other.gameObject); // Remove a nave inimiga
            Destroy(gameObject);       // Remove o míssil

        }

        if(GameManager.num_invaders == 0){
            Invader.naoMatou = 0;
            GameManager.notifyWinner();
        }
        
    }
}