using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceShipMove : MonoBehaviour{
    public float boundRigth = 5.65f;            // Define os limites na direita
    private Rigidbody2D rb2d;
    void Start(){
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Wall"){
            Destroy(gameObject);
        }
    }


    void Update(){
        Vector3 newPosition = transform.position;
        newPosition.x += 0.010f;
        transform.position = newPosition;
    }
}
