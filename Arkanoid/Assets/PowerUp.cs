using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float fallSpeed = 4.0f;  // Velocidade de queda
    public float boundY = -28.63f; // Limite inferior para destruição

    public bool startGame = false;
    void OnTriggerEnter2D (Collider2D hitInfo) {
        if (hitInfo.tag == "Player"){
            Vector3 playerScale = hitInfo.transform.localScale;
            
            playerScale.x += 1;
            hitInfo.transform.localScale = playerScale;

            Destroy(gameObject);
            
            
        }
    }


    

    

    void Start(){
        rb2d = GetComponent<Rigidbody2D>(); 
    }

    void Update(){
        if ( !startGame && Input.GetKeyDown(KeyCode.Space)){
            startGame = true;
            rb2d.velocity = new Vector2(0, -fallSpeed); // Faz o objeto cair automaticamente
            if (transform.position.y <= boundY){
                Destroy(gameObject);
            }
        }
        
    }

}
