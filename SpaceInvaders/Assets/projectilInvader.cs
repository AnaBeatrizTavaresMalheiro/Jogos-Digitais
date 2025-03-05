using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectilInvader : MonoBehaviour{
    public float speed = 5f;
    public GameObject explosionPrefab;

    void Update(){
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){

        if (other.CompareTag("Player")){
            Instantiate(explosionPrefab , other.transform.position , other.transform.rotation);
            GameManager.notifyLifeLost();
            Destroy(gameObject);       // Remove o míssil
        }
        
        else if (other.CompareTag("Wall")){
            Destroy(gameObject); // Remove o míssil ao colidir com a parede
        }

    }
}
