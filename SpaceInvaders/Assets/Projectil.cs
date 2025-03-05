using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectil : MonoBehaviour{
    public float speed = 5f;
    public GameObject explosionPrefab;

    void Update(){
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){

        if (other.CompareTag("Alien1") || other.CompareTag("Alien2") || other.CompareTag("Alien3") || other.CompareTag("NaveMae")){

            if(other.CompareTag("Alien1")){
                GameManager.notifyScore(10);
                GameManager.invaders -= 1;
            }
            else if(other.CompareTag("Alien2")){
                GameManager.notifyScore(20);
                GameManager.invaders -= 1;
            }
            else if(other.CompareTag("Alien3")){
                GameManager.notifyScore(30);
                GameManager.invaders -= 1;
            }
            else{
                GameManager.notifyScore(50);
            }
            
            Instantiate(explosionPrefab , other.transform.position , other.transform.rotation);
            Destroy(other.gameObject); // Remove a nave inimiga
            Destroy(gameObject);       // Remove o míssil
        }
        
        else if (other.CompareTag("Wall")){
            Destroy(gameObject); // Remove o míssil ao colidir com a parede
        }

        if(GameManager.invaders == 0){
            GameManager.notifyWinner();
        }
        
    }
}
