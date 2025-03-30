using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour{
    public float speed = 5f;

    void Update(){
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D other){
        if (other.CompareTag("Serpente")){
            Destroy(other.gameObject); // Remove a serpente
            Destroy(gameObject);       // Remove o míssil
        }
        // else{
        //     Destroy(gameObject); // Remove o míssil se colidir com qualquer outra coisa
        // }    
    }
}
